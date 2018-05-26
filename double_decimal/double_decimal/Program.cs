using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter WR = new StreamWriter("hockey.out");
            StreamReader Fin = new StreamReader("hockey.in");



            string[] s = Fin.ReadLine().Replace(".", ",").Split();
            double h = Convert.ToDouble(s[0]);
            double w = Convert.ToDouble(s[1]);
            double w1 = Convert.ToDouble(s[2]);
            double w2 = Convert.ToDouble(s[3]);
            Fin.Close();
            double x = ((w1 + w2) / 2) * h * 2 + (w1 * w) + (Math.Sqrt(h * h + (w2 - w1) * (w2 - w1))) * w;
            WR.Write(String.Format("{0:0.00000}", x).Replace(",", "."));
            WR.Close();
        }
    }
}