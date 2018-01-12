using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace YourPad
{
    class Program
    {
        static void Main(string[] args)
        {
            string ch;
            do
            {
                Menu menu = new Menu();
                menu.ShowMenu();
                menu.ChooseMenu();
                Console.WriteLine("是否继续（y/n）");
                ch = Console.ReadLine();
            } while (ch == "y" || ch == "Y");
            
        }
    }
}
