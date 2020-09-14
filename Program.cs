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
            for (int i = 0; i < adat.Length; i++)
            {
                //adat[i] = int.Parse(sor[i]);
                adat[i] = int.Parse(olvas.ReadLine()) * 3;
                Console.WriteLine(adat[i]);
            }
        }        
        static int Minimumertek()
        {
            int min = adat[0];
            for (int i = 1; i < adat.Length; i++)
            {
                if (min>adat[i])
                {
                    min = adat[i];
                }
            }
            return min;
        }
        static int Egyediek()
        {
            // 5-el osztható, de 4-el nem
            int egyedi = 0;
            for (int i = 0; i < adat.Length; i++)
            {
                if (adat[i]%5==0 && adat[i]%4==1)
                {
                    egyedi++;
                }
            }
            StreamWriter iro = new StreamWriter("egyediek.txt");
            for (int i = 0; i < adat.Length; i++)
            {
                iro.WriteLine(adat[egyedi]);
            }
            return egyedi;
        }
        static void Main(string[] args)
        {
            Beolvasas();
            Console.WriteLine("A minimum: {0}", Minimumertek());
            //Console.WriteLine("5 osztható de 4 nem oszthatóak száma: {0}", Egyediek());
            Console.ReadKey();
        }
    }
}
