using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace B01MakkaiPeter
{
    class Program
    {
        static int[] adat = new int[1000];
        static void Beolvasas()
        {
            StreamReader olvas = new StreamReader("adatok.dat");
            string[] sor = olvas.ReadLine().Split();
            for (int i = 0; i < adat.Length; i++)
            {
                //adat[i] = int.Parse(sor[i]);
                adat[i] = 3*int.Parse(sor[0]);           
                Console.WriteLine(adat[i]);
            }
        }
        static int Minimumertek()
        {
            int min = adat[0];
            for (int i = 0; i < adat.Length; i++)
            {
                if (min<adat[i])
                {
                    min = adat[i];
                }
            }
            return min;
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.ReadKey();
        }
    }
}
