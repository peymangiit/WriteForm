using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteForm
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, family;
            Console.WriteLine("please write your name:");
            name = Console.ReadLine();
            Console.WriteLine("please write your family:");
            family = Console.ReadLine();
            //name = "hamid";
           // family = "Roshan";
            Console.WriteLine("                          ┌──────────────────────────────────────────────────────────┐");
            Console.WriteLine("                          |   Name |"+name+"    |                   Family| "+family+" |    |");
        }
    }
}
 