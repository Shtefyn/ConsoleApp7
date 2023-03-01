using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     1 ZADANIE
             *
             * var miasto = new string[] { "Olkusz", "Krakow", "Poznan", "London", "Gdynia" };
             var numer = new int[] { 1, 6, 17, 25, 9 };
             var ułamek = new float[] { 1.5f, 16.78f, 99.99f, 0.13f, 0.5f };
             var znak = new char[] {'f', 'j', '>', 'O' , 'p' };
             var liczba = new double[] { 2167, 6717, 421412, 4124, 4124412 };

             Console.WriteLine($" Miasta: {miasto[0]} {miasto[1]} {miasto[2]} {miasto[3]} {miasto[4]}");
             Console.WriteLine($" Numery: {numer[0]} {numer[1]} {numer[2]} {numer[3]} {numer[4]}");
             Console.WriteLine($" Ułamki: {ułamek[0]} {ułamek[1]} {ułamek[2]} {ułamek[3]} {ułamek[4]}");
             Console.WriteLine($" Znaki: {znak[0]} {znak[1]} {znak[2]} {znak[3]} {znak[4]}");
             Console.WriteLine($" Liczby: {liczba[0]} {liczba[1]} {liczba[2]} {liczba[3]} {liczba[4]}");
             */


            /* ZADANIE 2
            double potega1 = Math.Pow(4, 1);
            double potega2 = Math.Pow(4, 2);
            double potega3 = Math.Pow(4, 3);
            double potega4 = Math.Pow(4, 4);
            for(int i = 0; i < 5; i++)
            {
                double potega5 = Math.Pow(4, i);
            }
            Console.WriteLine($"{pote}");


            Console.ReadLine();    */


            /* ZADANIE 3
            Console.WriteLine("Hej, Witamy w kinie! Bilet na film 'Piła' kosztuje 20zł");
            Console.WriteLine("Ile masz lat?!");
            string wiek = Console.ReadLine();
            var success1 = double.TryParse(wiek, out double liczba1);
            if (!success1)
            {
               return;
            }
            
            if (success1)
            {
                Console.WriteLine("Okej, teraz musimy wiedzieć ile masz oszczędności na koncie.");
            }
                var money = Console.ReadLine();
            var success2 = double.TryParse(money, out double liczba2);
            if (!success2)
            {
                return;
            }

            if (liczba1 >= 16 && liczba2 >= 20 && success1 && success2)
            {
                Console.WriteLine("Spełniono wymagania, zapraszamy!");
            }
            else
            {
                Console.WriteLine("Nie spełniono wymagań!");         
            }
            Console.ReadLine();     */
                        

                  
        }
    }
}
