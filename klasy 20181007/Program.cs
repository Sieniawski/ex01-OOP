using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_20181007
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();
            osoba.Imie = "Wojciech";
            osoba.Nazwisko = "Sieniawski";

            Console.WriteLine($"Imie = {osoba.Imie} Nazwisko = {osoba.Nazwisko}");
            Console.ReadKey();
        }
    }
}
