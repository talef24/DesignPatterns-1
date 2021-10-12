using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AppLogic
{
    public class AppSettings
    {
        private const string k_FilePath = @"C:\Temp\appSettings.xml";

        public Point LastWindowLocation { get; set; }

        public string LastPageColor { get; set; }
        
        public string LastButtonsColor { get; set; }
        
        public string LastNameColor { get; set; }
        
        public string LastMoto { get; set; }
        
        public bool RememberUser { get; set; }
        
        public string LastAccessToken { get; set; }

        public List<List<string>> TasksInCalendar { get; set; }
        
        public List<string> DatesInCalendar { get; set; }
        
        public List<List<int>> PhotosIndexsInAlbum { get; set; }
        
        public List<int> AlbumsIndexs { get; set; }

        private AppSettings()
        {
            LastWindowLocation = new Point(20, 50);
            LastPageColor = "WhiteSmoke";
            LastButtonsColor = "MidnightBlue";
            LastNameColor = "Black";
            LastMoto = string.Empty;
            RememberUser = false;
            LastAccessToken = null;
            TasksInCalendar = new List<List<string>>();
            DatesInCalendar = new List<string>();
            PhotosIndexsInAlbum = new List<List<int>>();
            AlbumsIndexs = new List<int>();
        }

        public static AppSettings LoadAppSettingsFromFile()
        {
            AppSettings appSettings;
            try
            {
                using (Stream stream = new FileStream(k_FilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }
            catch
            {
                appSettings = new AppSettings();
            }

            return appSettings;
        }

        public void SaveAppSettingsToFile()
        {
            if (!File.Exists(k_FilePath))
            {
                writeToStream(FileMode.Create);
            }
            else
            {
                writeToStream(FileMode.Truncate);
            }
        }

        private void writeToStream(FileMode i_FileMode)
        {
            FileMode fileMode = i_FileMode;
            using (Stream stream = new FileStream(k_FilePath, fileMode))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        } 
    }
}