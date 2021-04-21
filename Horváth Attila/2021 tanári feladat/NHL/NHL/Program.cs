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
            foreach (var item in File.ReadAllLines("NFL_iranyitok.txt"))
            {
                jatekosok.Add(new Jatekos(sor));
            }
        }

    }
}
