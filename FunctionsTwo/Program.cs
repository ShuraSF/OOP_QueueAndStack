using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CrossProject
{
    // Функции и методы C#

    class Program
    {
        static void PrintLine()
        {
            WriteLine("Метод PrintLine - был вызван!");
        }
        static void Main(string[] args)
        {
            PrintLine();
            Random random = new Random();
            WriteLine(random.Next());
        }
    }
}