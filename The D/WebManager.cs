using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace The_D
{
    public class WebManager : IDalManager
    {
        public string GetData(string location)
        {
            string data = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(location);

                //If required by the server, set the credentials.
                request.Credentials = CredentialCache.DefaultCredentials;

                // Get the response.
                WebResponse response = request.GetResponse();

                // Get the stream containing content returned by the server.
                // The using block ensures the stream is automatically closed.
                using (Stream dataStream = response.GetResponseStream())
                {
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    data = reader.ReadToEnd();
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
