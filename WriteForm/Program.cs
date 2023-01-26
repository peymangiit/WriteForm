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
            int birthday,id_number;
            Console.WriteLine("please write your name:");
            name = Console.ReadLine();
            Console.WriteLine("please write your family:");
            family = Console.ReadLine();
            Console.WriteLine("please write your birthday:(year only)");
            birthday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please write your id-Number:(5 digit)");
            id_number = Convert.ToInt32(Console.ReadLine());
            //name = "hamid";
           // family = "Roshan";
            Console.WriteLine("                          ┌──────────────────────────────────────────────────────────┐");
            Console.WriteLine("                          |   Name |"+name+"    |                   Family| "+family+" |    |");
            Console.WriteLine("                          |                                                          |");
            Console.WriteLine("                          |                                                          |");
            Console.WriteLine("                          | birthday |{0}|                      id-Number |{1}|   |",birthday,id_number);
            Console.WriteLine("                          |                                                          |");
            Console.WriteLine("                          |                                                          |");
            Console.WriteLine("                          |                                                          |");
        }
    }
}
 