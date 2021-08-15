using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
     public class AppSettings
     {
          public bool m_RememberUser { get; set; }
          public string m_LastAccessToken { get; set; }

          public AppSettings()
          {
               m_RememberUser = false;
               m_LastAccessToken = null;
          }

          public void SaveToFile()
          {
               using (Stream stream = new FileStream(@"C:\Users\Dor Sabag\Documents\GitHub\Design-Paterrens-Project-1\FacebookWinFormsApp\AppSettings.xml", FileMode.OpenOrCreate))
               {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
               }
          }
          public static AppSettings LoadFromFile()
          {
               AppSettings appSettings = new AppSettings();

               if (File.Exists(@"C:\Users\Dor Sabag\Documents\GitHub\Design-Paterrens-Project-1\FacebookWinFormsApp\AppSettings.xml"))
               {
                    using (Stream stream = new FileStream(@"C:\Users\Dor Sabag\Documents\GitHub\Design-Paterrens-Project-1\FacebookWinFormsApp\AppSettings.xml", FileMode.Open))
                    {
                         XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                         appSettings = serializer.Deserialize(stream) as AppSettings;
                    }
               }
               return appSettings;
          }

     }
}
