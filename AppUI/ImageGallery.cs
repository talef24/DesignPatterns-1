using System;
using System.Collections.Generic;
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
    public partial class ImageGallery : Form
    {
        private readonly User r_LoggedInUser;
        private readonly MainForm r_MainForm;

        public ImageGallery(MainForm i_MainForm)
        {
            InitializeComponent();
            r_LoggedInUser = i_MainForm.AppManager.LoggedInUser;
            r_MainForm = i_MainForm;
        }

        private void imageGallery_Load(object sender, EventArgs e)
        {
            displayImageGallery();
        }

        private void displayImageGallery()
        {
            Point locationPictureBox = new Point(AppLogic.Constants.k_StartLocationX, pictureBoxCover.Bottom);
            Point locationbutton = new Point(AppLogic.Constants.k_StartLocationX, locationPictureBox.Y + Constants.k_PictureBoxHeight);
            for (int i = 0; i < r_LoggedInUser.Albums.Count; i++)
            {   
                PictureBoxSettings(ref locationPictureBox, this, r_LoggedInUser.Albums[i].CoverPhoto.PictureAlbumURL, i);
                Button currentButton = ButtonSettings(ref locationbutton, this, r_LoggedInUser.Albums[i].Name, i);
                currentButton.Click += new EventHandler(currentButton_Click);
            }
        }

        public void PictureBoxSettings(ref Point io_Location, Form i_Form, string i_PictureURL, int i_Index)
        {
            PictureBox currentPictureBox = new PictureBox();
            currentPictureBox.LoadAsync(i_PictureURL);
            currentPictureBox.Size = new Size(AppLogic.Constants.k_PictureBoxWidth, AppLogic.Constants.k_PictureBoxHeight);
            currentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            currentPictureBox.Location = SetLocation(ref io_Location, i_Index);
            i_Form.Controls.Add(currentPictureBox);
        }

        public Button ButtonSettings(ref Point io_Location, Form i_Form, string i_ButtonText, int i_Index)
        {
            Button currentButton = new Button();
            currentButton.Name = i_Index.ToString();
            currentButton.Text = i_ButtonText;
            currentButton.Width = AppLogic.Constants.k_ButtonsWidth;
            currentButton.Location = SetLocation(ref io_Location, i_Index);
            i_Form.Controls.Add(currentButton);

            return currentButton;
        }

        public Point SetLocation(ref Point io_Location, int i_Index)
        {
            if (i_Index % AppLogic.Constants.k_NumberPhotosInRow == 0)
            {
                if (i_Index != 0)
                {
                    io_Location.X = AppLogic.Constants.k_StartLocationX;
                    io_Location.Y += AppLogic.Constants.k_Space;
                }
            }
            else
            {
                io_Location.X += AppLogic.Constants.k_Space;
            }

            return io_Location;
        }

        private void currentButton_Click(object sender, EventArgs e)
        {
            Button currentButton = sender as Button;
            ImageGalleryAlbum photosInCurrentAlbum = new ImageGalleryAlbum(r_MainForm, currentButton.Name);
            photosInCurrentAlbum.ShowDialog();
        }
    }
}