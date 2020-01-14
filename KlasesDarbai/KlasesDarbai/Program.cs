using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesDarbai
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            //p.VardoG("Mr. Dee",25);
            Console.WriteLine(p.KMI(55,1.70));
            Console.ReadLine();
        }

        public void VardoG(string vardas,int kiekis)
        {
            for (int i = 0; i < kiekis; i++)
            {
                Console.WriteLine("{0}", vardas);
            }

        }

        public string Sharpas(string eilute)
        {
            int SimbolK = eilute.Length;
            string EiluteG = "";
            
            for (int i = 0; i < SimbolK; i++)
            {
                EiluteG = EiluteG + "#";
            }
            return EiluteG;
        }

        public double KMI(double mase, double ugis)
        {

            double kmi = mase / Math.Pow(ugis,2);
            return Math.Round(kmi,2);

        }

    }
}
