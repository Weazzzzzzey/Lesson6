using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilietuSistema
{
    class BilietuApskaita
    {
        int Bilietai10 = 100;
        int Bilietai20 = 100;
        int Bilietai30 = 100;

        public void Meniu()
        {
            Console.WriteLine("Pirkti Bilietus spauskite - 1");
            Console.WriteLine("Kurti Bilietus spauskite - 2");
        }

        public void Tipai()
        {
            Console.WriteLine("Pasirikite bilietu Tipa:");
            Console.WriteLine("Bilietai uz 10e spauskite - 1");
            Console.WriteLine("Bilietai uz 20e spauskite - 2");
            Console.WriteLine("Bilietai uz 30e spauskite - 3");
            Console.WriteLine("Ir iveskite ju kieki");
        }
        public void BilietuPirkimas(int tipas, int kiekis)
        {
            Console.WriteLine("{0} {1}", tipas, kiekis );
            //Bilietai uz 10e
            if (tipas == 1 && kiekis <= Bilietai10)
            {
                Bilietai10 = Bilietai10 - kiekis;
            }
            else
            {
                Console.WriteLine("1 Bilietu kiekis nepakankamas");
            }
            
            //Bilietai uz 20e
            if (tipas == 2 && kiekis <= Bilietai20)
            {
                Bilietai20 = Bilietai10 - kiekis;
            }
            else
            {
                Console.WriteLine("2 Bilietu kiekis nepakankamas");
            }
            
            //Bilietai uz 30e
            if (tipas == 3 && kiekis <= Bilietai30)
            {
                Bilietai30 = Bilietai10 - kiekis;
            }
            else
            {
                Console.WriteLine("3 Bilietu kiekis nepakankamas");
            }
            Console.WriteLine();
        }

        public int getBilietai10()
        {
            return Bilietai10;
        }

        public int getBilietai20()
        {
            return Bilietai20;
        }
        public int getBilietai30()
        {
            return Bilietai30;
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BilietuApskaita ba = new BilietuApskaita();
            ba.Meniu();
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (pasirinkimas == 1)
            {
                ba.Tipai();
                ba.BilietuPirkimas(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(ba.getBilietai10());
                Console.WriteLine(ba.getBilietai20());
                Console.WriteLine(ba.getBilietai30());
            }
            else if (pasirinkimas == 2)
            {
                ba.Tipai();

            }


            Console.ReadLine();
        
        }
    }
}
