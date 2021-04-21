using System;
using System.Collections.Generic;
using System.Text;

namespace NFL
{
    


    class Jatekos
    {
        public String Név { get; set; }
        public int Yardok { get; set; }
        public int Kísérletek { get; set; }
        public int Passzok { get; set; }
        public int TDk { get; set; }
        public int Eladott { get; set; }
        public double Mutató { get; set; }
        public String Egyetem { get; set; }
        private double Konvertal(string iranyitoMutato)
        {
            var decimalSeparator = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            iranyitoMutato = iranyitoMutato.Replace(",", decimalSeparator).Replace(".", decimalSeparator);
            if (double.TryParse(iranyitoMutato, out var ertek))
                return ertek;
            throw new FormatException("Hibás érték (irányítómutató)");
        }

        public string FormazottNev(string nev)
        {
            var n = nev.Split(' ');
            n[n.Length - 1] = n[n.Length - 1].ToUpper();
            return string.Join(" ", n);
        }
    }
}
