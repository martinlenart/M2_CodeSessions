using System;

namespace WineCellar
{
    public enum GrapeVariants
    {
        Shiraz, Merlot, Chablis, Riesling
    }
    public struct Wine
    {
        public int Year;
        public string Name;
        public GrapeVariants Grape;
        public string Region;

        /// <summary>
        /// Method that creates a string representing the content of the Wine struct
        /// </summary>
        /// <returns>string from Wine struct</returns>
        public string StringToPrint()
        {
            string sRet = $"Wine {Year} {Name} is made of {Grape} from {Region}";
            return sRet;
        }
        public void Print()
        {
            Console.WriteLine(StringToPrint());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            const int maxNrBottles = 10;

            Wine wine1 = new Wine { Year = 2015, Name = "Vin A", Grape = GrapeVariants.Shiraz, Region = "Puglia" };
            Wine wine2 = new Wine { Year = 2020, Name = "Vin B", Grape = GrapeVariants.Riesling, Region = "Pfalz" };

            Console.WriteLine($"Wine {wine1.Year} {wine1.Name} is made of {wine1.Grape} from {wine1.Region}");
            Console.WriteLine($"Wine {wine2.Year} {wine2.Name} is made of {wine2.Grape} from {wine2.Region}");

            Console.WriteLine(wine1.StringToPrint());
            Console.WriteLine(wine2.StringToPrint());

            wine1.Print();
            wine2.Print();

            Wine[] myCellar = new Wine[maxNrBottles];

            myCellar[0] = wine1;
            myCellar[1] = wine2;
            myCellar[2] = new Wine { Year = 2020, Name = "Vin C", Grape = GrapeVariants.Riesling, Region = "Pfalz" };


            //Printout my wine cellar
            Console.WriteLine();
            int NrBottles = 0;
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i].Name != null)
                {
                    myCellar[i].Print();
                    NrBottles++;
                }
            }
            Console.WriteLine($"My cellar has {NrBottles} wines.");


            //Find my Wine
            string searchWine = "Vin D";
            for (int i = 0; i < NrBottles; i++)
            {
                if (myCellar[i].Name == searchWine)
                {
                    Console.WriteLine($"Wine {searchWine} found at position {i}");
                    Console.Beep();
                }
                else
                {
                    Console.WriteLine($"Wine {searchWine} finns inte");
                }
            }

        }
    }
}
