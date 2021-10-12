using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    public partial class MainForm : Form
    {
        private AppManager m_AppManager;
        private eClickMode m_MouseClickStatus = eClickMode.UnClickedMouse;
        private SwappingPhotosBox m_SwappingPhotosBox;

        public MainForm(AppManager i_AppManager)
        {
            m_AppManager = i_AppManager;
            InitializeComponent();
        }

        public AppManager AppManager
        {
            get { return m_AppManager; }
        }

        public SwappingPhotosBox SwappingPhotosBox
        {
            get { return m_SwappingPhotosBox; }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("Logged in as {0}", m_AppManager.LoggedInUser.Name);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = m_AppManager.AppSettings.LastWindowLocation;
            this.BackColor = Color.FromName(m_AppManager.AppSettings.LastPageColor);
            colorAllButtonsInSelectedColor(Color.FromName(m_AppManager.AppSettings.LastButtonsColor));
            labelUserName.ForeColor = Color.FromName(m_AppManager.AppSettings.LastNameColor);
            labelMotto.Text = m_AppManager.AppSettings.LastMoto;
            hideAllSettingsComboBoxs();
            if (m_AppManager.AppSettings.RememberUser)
            {
                checkBoxRememberMe.Checked = true;
            }
        }

        private void hideAllSettingsComboBoxs()
        {
            comboBoxPageColor.Hide();
            comboBoxButtonsColor.Hide();
            comboBoxNameColor.Hide();
            comboBoxMotto.Hide();
        }

        private void loadCalendar()
        {
            m_AppManager.Calendar.m_TasksToRemember = m_AppManager.AppSettings.TasksInCalendar;
            m_AppManager.Calendar.m_DatesToRemember = m_AppManager.AppSettings.DatesInCalendar;
            m_AppManager.Calendar.UpdateDictionary();
        }

        private void loadFavoritePhotos()
        {
            m_AppManager.PhotosIndexsToRemember = m_AppManager.AppSettings.PhotosIndexsInAlbum;
            m_AppManager.AlbumsIndexsToRemember = m_AppManager.AppSettings.AlbumsIndexs;
            m_AppManager.UpdateDictionary();

            setSwappingPhotosBox();
            for (int i = 0; i < m_AppManager.AppSettings.AlbumsIndexs.Count; i++)
            {
                int albumIndex = m_AppManager.AppSettings.AlbumsIndexs[i];
                List<int> favoritePhotosIndexesInAlbum = m_AppManager.AppSettings.PhotosIndexsInAlbum[i];
                foreach (int photoIndex in favoritePhotosIndexesInAlbum)
                {
                    m_SwappingPhotosBox.AddToSwappingPhotosBox(m_AppManager.LoggedInUser.Albums[albumIndex].Photos[photoIndex]);
                }

                m_SwappingPhotosBox.Start();
            }
        }

        private void setSwappingPhotosBox()
        {
            m_SwappingPhotosBox = new SwappingPhotosBox();
            m_SwappingPhotosBox.Size = new Size(383, 200);
            m_SwappingPhotosBox.Location = new Point(10, 180);
            m_SwappingPhotosBox.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(m_SwappingPhotosBox);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fetchUserPictures();
            fetchUserInfo();
            fetchUserPosts();
            loadCalendar();
            loadFavoritePhotos();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if(!checkBoxRememberMe.Checked)
            {
                m_AppManager.AppSettings.RememberUser = false;
            }

            updateLastUserSettings();
            Application.Exit();
        }

        private void updateLastUserSettings()
        {
            m_AppManager.AppSettings.LastWindowLocation = this.Location;
            m_AppManager.AppSettings.LastPageColor = this.BackColor.Name;
            m_AppManager.AppSettings.LastNameColor = labelUserName.ForeColor.Name;
            m_AppManager.AppSettings.LastMoto = labelMotto.Text;
            m_AppManager.AppSettings.LastButtonsColor = buttonAlbums.BackColor.Name;
            m_AppManager.AppSettings.LastAccessToken = m_AppManager.LoginResult.AccessToken;
            m_AppManager.AppSettings.SaveAppSettingsToFile();
        }

        private void fetchUserPictures()
        {
            pictureBoxProfile.LoadAsync(m_AppManager.LoggedInUser.PictureNormalURL);
            setProfilePictureShape();
        }

        private void setProfilePictureShape()
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(pictureBoxProfile.DisplayRectangle);
            pictureBoxProfile.Region = new Region(gp);
        }

        private void fetchUserInfo()
        {  
            labelUserName.Text = m_AppManager.LoggedInUser.Name;
            if (m_AppManager.LoggedInUser.Location != null)
            {
                labelLocation.Text = string.Format("{0} {1}", labelLocation.Text, m_AppManager.LoggedInUser.Location.Name);
            }

            if (m_AppManager.LoggedInUser.Birthday != null)
            {
                labelBirthday.Text = string.Format("{0} {1}", labelBirthday.Text, m_AppManager.LoggedInUser.Birthday);
            }

            if (m_AppManager.LoggedInUser.Hometown != null)
            {
                labelHomeTown.Text = string.Format("{0} {1}", labelHomeTown.Text, m_AppManager.LoggedInUser.Hometown.Name);
            }

            if (m_AppManager.LoggedInUser.RelationshipStatus != null)
            {
                if(m_AppManager.LoggedInUser.RelationshipStatus.Equals(User.eRelationshipStatus.Single))
                {
                    labelRelationshipStatus.Text = string.Format("{0} single", labelRelationshipStatus.Text);
                }

                if (m_AppManager.LoggedInUser.RelationshipStatus.Equals(User.eRelationshipStatus.InARelationship))
                {
                    labelRelationshipStatus.Text = string.Format("{0} In A Relationship", labelRelationshipStatus.Text);
                }
            }
        }

        private void fetchUserPosts()
        {
            foreach (Post post in m_AppManager.LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (m_AppManager.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve");
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = "Name";
            foreach (Event fbEvent in m_AppManager.LoggedInUser.Events)
            {
                listBoxEvents.Items.Add(fbEvent.Name);
            }

            if (m_AppManager.LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No Events to retrieve");
            }
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            fetchCheckIn();
        }

        private void fetchCheckIn()
        {
            listBoxCheckIn.Items.Clear();
            listBoxCheckIn.DisplayMember = "Name";

            foreach (Checkin checkin in m_AppManager.LoggedInUser.Checkins)
            {
                listBoxCheckIn.Items.Add(checkin);
            }

            if (m_AppManager.LoggedInUser.Checkins.Count == 0)
            {
                MessageBox.Show("No check-in to retrieve");
            }
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            fetchGroups();
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";
            foreach (Group group in m_AppManager.LoggedInUser.Groups)
            {
                listBoxGroups.Items.Add(group);
            }

            if (m_AppManager.LoggedInUser.Groups.Count == 0)
            {
                MessageBox.Show("No group to retrieve");
            }
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.DisplayMember = "Name";
            listBoxFriends.DataSource = m_AppManager.LoggedInUser.Friends;

            if (m_AppManager.LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No friends to retrieve");
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            ImageGallery photoAlbums = new ImageGallery(this);
            photoAlbums.ShowDialog();
        }

        private void pictureBoxSetting_Click(object sender, EventArgs e)
        {
            if(m_MouseClickStatus.Equals(eClickMode.UnClickedMouse))
            {
                comboBoxPageColor.Show();
                comboBoxButtonsColor.Show();
                comboBoxNameColor.Show();
                comboBoxMotto.Show();
                m_MouseClickStatus = eClickMode.ClickedMouse;
            }
            else
            {
                hideAllSettingsComboBoxs();
                m_MouseClickStatus = eClickMode.UnClickedMouse;
            }
        }

        private void comboBoxPageColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxPageColor.SelectedIndex == Constants.k_FirstOption)
            {
                this.BackColor = Color.FromName("WhiteSmoke");
            }

            if(comboBoxPageColor.SelectedIndex == Constants.k_SecondOption)
            {
                this.BackColor = Color.FromName("Pink");
            }

            if(comboBoxPageColor.SelectedIndex == Constants.k_ThirdOption)
            {
                this.BackColor = Color.FromName("PaleGreen");
            }
        }

        private void comboBoxButtonsColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color selectedColor = Color.MidnightBlue; 
            if (comboBoxButtonsColor.SelectedIndex == Constants.k_SecondOption)
            {
                selectedColor = Color.Black;
            }

            colorAllButtonsInSelectedColor(selectedColor);
        }

        private void colorAllButtonsInSelectedColor(Color i_SelectedColor)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = i_SelectedColor;
                }
            }
        }

        private void comboBoxNameColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNameColor.SelectedIndex == Constants.k_FirstOption)
            {
                labelUserName.ForeColor = Color.Black;
            }

            if (comboBoxNameColor.SelectedIndex == Constants.k_SecondOption)
            {
                labelUserName.ForeColor = Color.Red;
            }

            if (comboBoxNameColor.SelectedIndex == Constants.k_ThirdOption)
            {
                labelUserName.ForeColor = Color.Yellow;
            }
        }

        private void comboBoxMotto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMotto.SelectedIndex != Constants.k_FirstOption)
            {
                labelMotto.Text = comboBoxMotto.Text;
            }
            else
            {
                labelMotto.Text = string.Empty;
            }
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRememberMe.Checked)
            {
                m_AppManager.AppSettings.RememberUser = true;
            }
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            CalendarForm calendar = new CalendarForm(m_AppManager);
            calendar.ShowDialog();
        }
    }
}