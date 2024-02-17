using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vettore v = new vettore(1 ,2);
            vettore v2 = new vettore(3, 4);
            double s = 5;

            vettore somma = v+v2;
            vettore diff = v - v2;
            vettore per = v * s;
            vettore diviso = v / s;
            double vscalare = v * v2;
            vettore per2 = s * v;
            vettore menov = -v;
            vettore piuv = +v;

            Console.WriteLine("somma = {0}", somma);
            Console.WriteLine("differenza = {0}", diff);
            Console.WriteLine("moltiplicazione = {0}", per);
            Console.WriteLine("divisione = {0}", diviso);
            Console.WriteLine("prodotto scalare = {0}", vscalare);
            Console.WriteLine("moltiplicazione v2 = {0}", per2);
            Console.WriteLine("vettore inverso = {0}", menov);
            Console.WriteLine("vettore identità = {0}", piuv);
            Console.ReadLine();

        }
    }
}
