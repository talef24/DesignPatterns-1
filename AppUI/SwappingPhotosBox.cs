using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace AppUI
{
    public class SwappingPhotosBox : PictureBox
    {
        private const int k_IntervalTime = 3000;
        private readonly List<Image> r_Images = new List<Image>();
        private readonly Timer r_Timer = new Timer();

        public SwappingPhotosBox()
            : base()
        {
            r_Timer.Tick += changeImage;
            r_Timer.Interval = k_IntervalTime;
        }

        public List<Image> Images
        {
            get { return r_Images; }
        }

        public void AddToSwappingPhotosBox(Photo i_Photo)
        {
            Image image = i_Photo.ImageNormal;
            r_Images.Add(image);
        }

        public void RemoveFromSwappingPhotosBox(Photo i_Photo)
        {
            Image image = i_Photo.ImageNormal;
            r_Images.Remove(image);
        }

        public void Start()
        {
            if(r_Images.Count != 0)
            {
                this.Image = r_Images[0];
                r_Timer.Start();
                this.Show();
            }
        }

        private void changeImage(object sender, EventArgs e)
        {
            if(r_Images.Count > 0)
            {
                Image = Images[new Random().Next(Images.Count)];
            }
            else
            {
                this.Hide();
                r_Timer.Stop();
            }
        }
    }
}