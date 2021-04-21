using System;
using System.Collections.Generic;
using System.IO;
namespace szudoku
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Feladvany> feladványok = new List<Feladvany>();
            StreamReader sr = new StreamReader("feladványok.txt");
             while (!sr.EndOfStream)
            {
                feladványok.Add(new Feladvany(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("3. Feladat: Beolvassva {0} feladvány", feladványok.Count);

            int meret;

            do
            {
                Console.WriteLine("4. feladata: Kérem a feladvány méretét! [4..9]: ");
                meret = int.Parse(Console.ReadLine());
            } while (meret < 4 || meret > 9);

            List<Feladvany> nElemufeladványok = new List<Feladvany>();
            foreach (var f in feladványok)
            {
                if (f.Meret == meret)
                {
                    nElemufeladványok.Add(f);
                }

            }
            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", meret, nElemufeladványok.Count);

            Random rand = new Random();
            int index = rand.Next(nElemufeladványok.Count);
            var kivalaszhtottfeladvány = nElemufeladványok[index];

            Console.WriteLine("5. feladat: A kiválasztott feladvány: ");
            Console.WriteLine(kivalaszhtottfeladvány.Kezdo);

            double db = 0;
            foreach (char szamjegy in kivalaszhtottfeladvány.Kezdo)
            {
                if (szamjegy != '0')
                {
                    db++;
                }
            }
            Console.WriteLine("6. feladat: a feladvány kitöltötsége: {0:f0}", 100 * db / kivalaszhtottfeladvány.Kezdo.Length);

            Console.WriteLine("7. feladat: A feladavány kirajzolva: ");
            kivalaszhtottfeladvány.Kirajzol();

            string fajlNev = string.Format("sudoku{0}.txt", meret);
            StreamWriter sw = new StreamWriter(fajlNev);
            foreach (var F in nElemufeladványok)
            {
                sw.WriteLine(F.Kezdo);
            }
            Console.WriteLine("8.feladat: {0} állomány {1} darab feladvánnyal létrehozva", fajlNev, nElemufeladványok.Count);
            sw.Close();
           
        }
    }
}
