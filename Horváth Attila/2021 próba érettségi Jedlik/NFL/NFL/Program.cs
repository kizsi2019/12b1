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
        }
        
    }
}
