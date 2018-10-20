using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasy_20181007
{
    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private int wiek;


        

        public string Imie
        {
            get
            {
                return this.imie;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && this.Imie.Equals("Nieznany"))
                    this.imie = value;
            }
        }

        public string Nazwisko
        {
            get
            {
                return this.imie;
            }
            set
            {
                if (!string.IsNullOrEmpty(value) && this.Nazwisko.Equals("Nieznany"))
                    this.nazwisko = value;
            }
        }

        public int Wiek
        {
            get
            {
                return this.wiek;
            }
            set
            {
                if (value >= 0)
                    this.wiek = value;
                else
                    throw new Exception("Błędna wartość wieku.");
            }
        }

        public Osoba()
        {
            //do get/set
            imie = "Nieznany";
            nazwisko = "Nieznany";
            wiek = 0;
        }

        public Osoba(string Imie, string Nazwisko)
        {
            if (!string.IsNullOrEmpty(Imie))
                this.Imie = Imie;

            if (!string.IsNullOrEmpty(Nazwisko))
                this.Nazwisko = Nazwisko;
        }

        public Osoba(string Imie, string Nazwisko, int Wiek)
        {
            if (!string.IsNullOrEmpty(Imie))
                this.Imie = Imie;

            if (!string.IsNullOrEmpty(Nazwisko))
                this.Nazwisko = Nazwisko;

            if (Wiek > 0)
                this.Wiek = Wiek;
        }
    }
}

