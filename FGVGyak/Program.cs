using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGVGyak
{
    class Program
    {
        static double GombFelszin(double r) 
        { 
            double felszin = 4 * r * r * Math.PI; 
            return felszin; 
        }

        static double GombTerfogat(double r) 
        { 
            double terfogat = 4 * r * r * r * Math.PI / 3; 
            return terfogat; 
        }

        static double KupFelszin(double r, double a) 
        { 
            return (r * r * Math.PI + r * Math.PI * a); 
        }

        static double KupTerfogat(double r, double m)
        {
            return (r * r * Math.PI / 3);
        }

        static double TombAtlag(int[] tomb) 
        { 
            int osszeg = 0; 
            for (int i = 0; i < tomb.Length; i++) 
            { 
                osszeg += tomb[i]; 
            } 
            return (osszeg / tomb.Length); 
        }


        

        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();

            Console.ReadKey();
        }

        static void Feladat1()
        {
            Console.WriteLine("Kérem a sugarat!");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A felszín: " + GombFelszin(r));
            Console.WriteLine("A térfogat: " + GombTerfogat(r));
        }

        static void Feladat2()
        {
            Console.WriteLine("Kérem a sugarat: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kérem a magasságot: "); 
            double m = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Kérem az alkotót: "); 
            double a = Convert.ToDouble(Console.ReadLine());

            //függvényhívások             
            Console.WriteLine("A felszín: " + KupFelszin(r, a));
            Console.WriteLine("A térfogat: " + KupTerfogat(r,m));
            Console.ReadKey();
        }

        static void Feladat3()
        {
            int[] tomb = new int[6]; 
            Random r = new Random(); 
            for (int i = 0; i < tomb.Length; i++) 
            { 
                tomb[i] = r.Next(1, 6); 
                Console.Write(tomb[i] + " "); 
            }

            //átlag számítása
            Console.WriteLine("\nAz átlag: " + TombAtlag(tomb)); 
        }
    }
}
