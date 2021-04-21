using System;
using System.IO;
using System.Collections.Generic;
using NHL;

namespace NFL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jatekos> jatekosok = new List<Jatekos>();
            foreach (var sor in File.ReadAllLines("NFL_iranyitok.txt"))
            {
                jatekosok.Add(new Jatekos(sor));
            }

            Console.WriteLine("5. feladat: A statisztikában {0} írányitó szerepel", jatekosok.Count);
            Console.WriteLine("7. feladat: A lejobb irányitók: ");
            foreach (var j in jatekosok)
            {
                if (j.mutató >=100 && j.YardMeter>= 4000)
                {
                    Console.WriteLine("\t {0} (irányitó mutató: {1}. Passzok: {2}m", j.FormazottNev(j.Név), j.mutató, j.YardMeter);
                }
            }

        }

    }
}
