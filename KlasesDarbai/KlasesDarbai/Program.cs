using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasesDarbai
{
    class NamuDarbaiNamie
    {

        public void fibo1()
        {
            
            int n1 = 0;
            int n2 = 1;
            int ats;

            for (int i = 2; i < 12+2; i++)
            {
                ats = n1 + n2;
                Console.Write(ats + " ");
                n1 = n2;
                n2 = ats;
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            NamuDarbaiNamie n = new NamuDarbaiNamie();
            //Console.WriteLine(n.fibo(1)); 
            n.fibo1();
            Console.ReadLine();
        }

        public void VardoG(string vardas, int kiekis)
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

            double kmi = mase / Math.Pow(ugis, 2);
            return Math.Round(kmi, 2);

        }

    }
}
