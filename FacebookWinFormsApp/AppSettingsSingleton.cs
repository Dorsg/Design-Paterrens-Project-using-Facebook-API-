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

     public sealed class AppSettingsSingleton
     {
          private static volatile AppSettingsSingleton instance;
          private static readonly object lockObject = new Object();
          public bool m_RememberUser { get; set; }
          public string m_LastAccessToken { get; set; }

          private AppSettingsSingleton()
          {
               m_RememberUser = false;
               m_LastAccessToken = null;
          }
          public static AppSettingsSingleton Instance
          {
               get
               {
                    if (instance == null)
                    {
                         lock (lockObject)
                         {
                              if (instance == null)
                              {
                                   instance = new AppSettingsSingleton();
                              }
                         }
                    }
                    return instance;
               }
          }
          public void SaveToFile()
          {
               using (Stream stream = new FileStream(@"C:\Users\Dor Sabag\Documents\GitHub\Design-Paterrens-Project-1\FacebookWinFormsApp\AppSettingsSingleton.xml", FileMode.OpenOrCreate))
               {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
               }
          }
          public static AppSettingsSingleton LoadFromFile()
          {
               AppSettingsSingleton appSettingsSingleton = new AppSettingsSingleton();

               if (File.Exists(@"C:\Users\Dor Sabag\Documents\GitHub\Design-Paterrens-Project-1\FacebookWinFormsApp\AppSettingsSingleton.xml"))
               {
                    using (Stream stream = new FileStream(@"C:\Users\Dor Sabag\Documents\GitHub\Design-Paterrens-Project-1\FacebookWinFormsApp\AppSettingsSingleton.xml", FileMode.Open))
                    {
                         XmlSerializer serializer = new XmlSerializer(typeof(AppSettingsSingleton));
                         appSettingsSingleton = serializer.Deserialize(stream) as AppSettingsSingleton;
                    }
               }
               return appSettingsSingleton;
          }
     }


}
