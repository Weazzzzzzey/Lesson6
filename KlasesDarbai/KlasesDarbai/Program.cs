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
            p.VardoG("Mr. Dee",25);
            Console.ReadLine();
        }

        public void VardoG(string vardas,int kiekis)
        {
            for (int i = 0; i < kiekis; i++)
            {
                Console.WriteLine("{0}", vardas);
            }

        }

    }
}
