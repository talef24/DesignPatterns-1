using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppLogic
{
    public class AppManager
    {
		private readonly Dictionary<int, List<int>> r_IndexOfFavoritePhotos = new Dictionary<int, List<int>>();
		private LoginResult m_LoginResult;
		private User m_LoggedInUser;
		private Calendar m_Calendar;
		private AppSettings m_AppSettings;
		private List<List<int>> m_PhotosIndexsToRemember;
		private List<int> m_AlbumsIndexsToRemember;

		public AppManager()
		{
			m_AppSettings = AppSettings.LoadAppSettingsFromFile();
		}

		public LoginResult LoginResult
		{
			get { return m_LoginResult; }
			set { m_LoginResult = value; }
		}

		public User LoggedInUser
		{
			get { return m_LoggedInUser; }
			set { m_LoggedInUser = value; }
		}

		public Calendar Calendar
		{
			get { return m_Calendar; }
			set { m_Calendar = value; }
		}

		public AppSettings AppSettings
		{
			get { return m_AppSettings; }
		}

		public Dictionary<int, List<int>> IndexOfFavoritePhotos
		{
			get { return r_IndexOfFavoritePhotos; }
		}

		public List<List<int>> PhotosIndexsToRemember
		{
			get { return m_PhotosIndexsToRemember; }
			set { m_PhotosIndexsToRemember = value; }
		}

		public List<int> AlbumsIndexsToRemember
		{
			get { return m_AlbumsIndexsToRemember; }
			set { m_AlbumsIndexsToRemember = value; }
		}

		public void Login()
		{
			if (m_LoginResult == null)
			{
				m_LoginResult = FacebookService.Login(
					"952170521974282",
					"public_profile",
					"email",
					"user_birthday",
					"user_gender",
					"user_link",
					"user_tagged_places",
					"user_videos",
					"user_friends",
					"user_events",
					"user_likes",
					"user_location",
					"user_photos",
					"user_hometown",
					"user_posts");
			}

			Init();
		}

		public void Init()
		{
			m_LoggedInUser = m_LoginResult.LoggedInUser;
			m_Calendar = new Calendar(m_LoggedInUser);
	    }

		public bool IsAccessTokenNull()
		{	
			return string.IsNullOrEmpty(m_LoginResult.AccessToken);
		}

		public void SaveIndexs()
		{
			List<List<int>> photosIndexs = new List<List<int>>();
			List<int> albumsIndexs = new List<int>();

			foreach (int key in r_IndexOfFavoritePhotos.Keys)
			{
				if (r_IndexOfFavoritePhotos.TryGetValue(key, out List<int> indexs))
				{
					photosIndexs.Add(indexs);
					albumsIndexs.Add(key);
				}
			}

			m_PhotosIndexsToRemember = photosIndexs;
			m_AlbumsIndexsToRemember = albumsIndexs;
		}

		public void UpdateDictionary()
		{
			for (int i = 0; i < m_AlbumsIndexsToRemember.Count; i++)
			{
				r_IndexOfFavoritePhotos.Add(m_AlbumsIndexsToRemember[i], m_PhotosIndexsToRemember[i]);
			}
		}
	}
}
