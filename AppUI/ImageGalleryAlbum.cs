using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppLogic;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    public partial class ImageGalleryAlbum : Form
    {
        private readonly User r_LoggedInUser;
        private readonly Album r_CurrentAlbum;
        private readonly int r_AlbumIndex;
        private readonly ImageGallery r_ImageGallery;
        private readonly AppManager r_AppManager;
        private readonly List<int> r_IndexesOfFavoritePhotos = new List<int>();
        private readonly MainForm r_MainForm;
        private ListBox m_CommentsListBox = new ListBox();
        private eClickMode m_MouseClickStatus = eClickMode.UnClickedMouse;

        public ImageGalleryAlbum(MainForm i_MainForm, string i_AlbumIndex)
        {
            InitializeComponent();
            r_LoggedInUser = i_MainForm.AppManager.LoggedInUser;
            r_AlbumIndex = int.Parse(i_AlbumIndex);
            r_CurrentAlbum = r_LoggedInUser.Albums[r_AlbumIndex];
            this.Text = r_CurrentAlbum.Name;
            r_ImageGallery = new ImageGallery(i_MainForm);
            r_MainForm = i_MainForm;
            r_AppManager = r_MainForm.AppManager;
            r_AppManager.IndexOfFavoritePhotos.TryGetValue(r_AlbumIndex, out r_IndexesOfFavoritePhotos);
            if (r_IndexesOfFavoritePhotos == null)
            {
                r_IndexesOfFavoritePhotos = new List<int>();
            }
        }

        private void imageGalleryAlbum_Load(object sender, EventArgs e)
        {
            Controls.Add(m_CommentsListBox);
            m_CommentsListBox.Hide();
            displayPhotos();
        }

        private void displayPhotos()
        {
            Point locationpictureBox = new Point(Constants.k_StartLocationX, pictureBoxInstruction.Bottom + Constants.k_StartLocationY);
            Point locationbutton = new Point(Constants.k_StartLocationX, locationpictureBox.Y + Constants.k_PictureBoxHeight);
            Point locationLabel = new Point(Constants.k_StartLocationX, locationbutton.Y + 25);
            Point locationCheckBox = new Point(Constants.k_StartLocationX, locationLabel.Y + 20);
            for (int i = 0; i < r_CurrentAlbum.Photos.Count; i++)
            {
                r_ImageGallery.PictureBoxSettings(ref locationpictureBox, this, r_CurrentAlbum.Photos[i].PictureAlbumURL, i);
                Button currentButton = r_ImageGallery.ButtonSettings(ref locationbutton, this, "Comments", i);
                currentButton.Click += new EventHandler(currentButton_Click);
                labelSettings(ref locationLabel, string.Format("Likes: {0}", r_CurrentAlbum.Photos[i].LikedBy.Count), i);
                checkBoxSettings(ref locationCheckBox, i, r_IndexesOfFavoritePhotos.Contains(i));
            }
        }

        private void labelSettings(ref Point io_Location, string i_LabelText, int i_Index)
        {
            Label currentLabel = new Label();
            currentLabel.Text = i_LabelText;
            currentLabel.Location = r_ImageGallery.SetLocation(ref io_Location, i_Index);
            Controls.Add(currentLabel);
            currentLabel.BringToFront();
        }

        private void checkBoxSettings(ref Point io_Location, int i_Index, bool i_IsChecked)
        {
            CheckBox addToFavoriteCheckBox = new CheckBox();
            addToFavoriteCheckBox.Name = i_Index.ToString();
            addToFavoriteCheckBox.Location = r_ImageGallery.SetLocation(ref io_Location, i_Index);
            Controls.Add(addToFavoriteCheckBox);
            addToFavoriteCheckBox.Checked = i_IsChecked;
            addToFavoriteCheckBox.CheckedChanged += addToFavoriteCheckBox_CheckedChanged;
        }

        private void addToFavoriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox currentCheckBox = sender as CheckBox;
            int photoIndex = int.Parse(currentCheckBox.Name);
            Photo photo = r_CurrentAlbum.Photos[photoIndex];
            if (currentCheckBox.Checked)
            {
                r_MainForm.SwappingPhotosBox.AddToSwappingPhotosBox(photo);
                if (!r_IndexesOfFavoritePhotos.Contains(photoIndex))
                {
                    r_IndexesOfFavoritePhotos.Add(photoIndex);
                }
            }
            else
            {
                r_MainForm.SwappingPhotosBox.RemoveFromSwappingPhotosBox(photo);
                r_IndexesOfFavoritePhotos.Remove(photoIndex);
            }
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            if (m_MouseClickStatus.Equals(eClickMode.UnClickedMouse))
            {
                displayComments(currentButton);
            }
            else
            {
                actionAfterDisplayComments(currentButton);
            }
        }

        private void displayComments(Button i_CurrentButton)
        {
            m_CommentsListBox.Items.Clear();
            int photoIndex = int.Parse(i_CurrentButton.Name);
            foreach (Comment comment in r_CurrentAlbum.Photos[photoIndex].Comments)
            {
                if (comment.Message != null)
                {
                    m_CommentsListBox.Items.Add(comment.Message);
                }
            }

            i_CurrentButton.Text = "Hide Comments";
            Point locationcommentsListBox = new Point(i_CurrentButton.Location.X + Constants.k_PictureBoxWidth, i_CurrentButton.Location.Y);
            m_CommentsListBox.Location = locationcommentsListBox;
            m_CommentsListBox.BringToFront();
            m_CommentsListBox.Show();
            m_MouseClickStatus = eClickMode.ClickedMouse;
        }

        private void actionAfterDisplayComments(Button i_CurrentButton)
        {
            if (i_CurrentButton.Text.Equals("Comments"))
            {
                MessageBox.Show("You must first hide other comments");
            }
            else
            {
                m_CommentsListBox.Hide();
                i_CurrentButton.Text = "Comments";
                m_MouseClickStatus = eClickMode.UnClickedMouse;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            r_MainForm.SwappingPhotosBox.Start();
            if (r_AppManager.IndexOfFavoritePhotos.ContainsKey(r_AlbumIndex))
            {
                r_AppManager.IndexOfFavoritePhotos.Remove(r_AlbumIndex);
            }

            r_AppManager.IndexOfFavoritePhotos.Add(r_AlbumIndex, r_IndexesOfFavoritePhotos);
            r_AppManager.SaveIndexs();
            r_AppManager.AppSettings.PhotosIndexsInAlbum = r_AppManager.PhotosIndexsToRemember;
            r_AppManager.AppSettings.AlbumsIndexs = r_AppManager.AlbumsIndexsToRemember;
        }
    }
}