using System;

namespace The_D
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GUI gui = new GUI();

                gui.Welcome();

                gui.GetDataView();

                Console.ReadLine();
            }
        }
    }
}
