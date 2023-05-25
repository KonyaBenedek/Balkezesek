using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Balkezesek;
using System.IO;
 

namespace Balkezesek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Balkezes> ballista = new List<Balkezes>();

            StreamReader sr = new StreamReader("balkezesek.csv", Encoding.UTF8);
            sr.ReadLine();
            while (!sr.EndOfStream) 
            {
                ballista.Add(new Balkezes(sr.ReadLine()));
            }
            sr.Close();

            Console.WriteLine($"3. feladat: {ballista.Count}");

            Console.WriteLine(new string('-', 40));
            const double inch = 2.54;

            Console.WriteLine($"4. feladat: ");
            ballista.Where(x => x.UtolsoLepes.Year == 1999 && x.UtolsoLepes.Month == 10).ToList().ForEach(y => Console.WriteLine($"{y.Nev}, {Math.Round(y.MagassagInchben * inch, 1)} cm"));

            Console.WriteLine(new string('-', 40));
        }
    }
}