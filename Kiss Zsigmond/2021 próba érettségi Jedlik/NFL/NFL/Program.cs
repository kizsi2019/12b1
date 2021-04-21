using System;
using System.Collections.Generic;
using System.IO;

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

            Console.WriteLine("5. feladat: A statisztikában {0} irányító szerepel", jatekosok.Count);

            Console.WriteLine("7. feladat: legjobb irányítók:");
            foreach (var j in jatekosok)
            {
                if (j.Mutató >= 100 && j.YardMeterben >= 4000)
                {
                    Console.WriteLine("\t {0} (irányító mutató: {1}. Passzok: {2}m", 
                        j.FormazottNev(j.Név), j.Mutató, j.YardMeterben);
                }
            }
        }
        
    }
}
