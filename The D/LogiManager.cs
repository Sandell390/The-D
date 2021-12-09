using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace The_D
{
    public class LogiManager
    {
        //public IDalManager dalManager = new WebManager();
        public IDalManager dalManager = new FileManager();

        public string GetData(string location)
        {
            //Tries to get data from dalmanager
            string data = dalManager.GetData(location);

            if (data == "ERROR")
            {
                return "Kunne ikke få fat på det eftersøgte data, Hav en god dag";
            }

            return dalManager.GetData(location);
        }

        public bool URLValidation(string url)
        {
            //Validation url
            return Uri.TryCreate(url, UriKind.Absolute, out Uri res);
        }
    }
}
