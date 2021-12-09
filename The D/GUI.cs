using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_D
{
    public class GUI
    {
        private LogiManager logiManager;

        public GUI()
        {
            logiManager = new LogiManager();
        }

        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til mit awesome side");
        }

        public void GetDataView()
        {
            //Gets the user to read an url to get data from
            Console.Write("URL: ");
            string url = Console.ReadLine();

            //Validation of the input url
            while (!logiManager.URLValidation(url))
            {
                Console.WriteLine();
                Console.WriteLine("Du skrev en forkert url, prøv igen");
                Console.Write("URL: ");
                url = Console.ReadLine();
            }

            Console.WriteLine($"Prøver at hente data fra {url}....");
            Console.WriteLine(logiManager.GetData(url));
        }

    }
}
