using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;

namespace The_D
{
    public class FileManager : IDalManager
    {

        public string GetData(string location)
        {
            string data = string.Empty;
            try
            {
                //Used to get the host string
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(location);

                //Reads json file
                string filename = "DataFile.json";
                string jsonString = File.ReadAllText(filename);

                //Gets data from the json file
                WebsiteDataManager wdm = JsonConvert.DeserializeObject<WebsiteDataManager>(jsonString);

                //Checks if the requested url is in our file
                foreach (WebData webData in wdm.Webdata)
                {
                    if (request.Host == webData.Url)
                    {
                        data = webData.Data;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                data = "ERROR";
            }
            
            return data;
        }
    }
}
