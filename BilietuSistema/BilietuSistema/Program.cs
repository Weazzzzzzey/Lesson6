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
        const string Nepakankamumas = "Kasoje nera tiek bilietu siuo metu.";
        const string BilietaiIpilti = "Bilietai prideti sekmingai.";
        const string GerosKeliones = "Malonu, kad renkates musu kompanija. Geros keliones!";
        const string PapildimoAprasas = "Noredami panaikinti bilietus pries ivedama skaiciu pridekite (-) zenkla.";

        public void ParodytiMeniu()
        {
            Console.WriteLine("Pirkti Bilietus spauskite - 1");
            Console.WriteLine("Kurti Bilietus spauskite - 2");
        }

        public void RodytiTipus()
        {
            Console.WriteLine("Pasirikite bilietu Tipa:");
            Console.WriteLine("Bilietai uz 10e spauskite - 1");
            Console.WriteLine("Bilietai uz 20e spauskite - 2");
            Console.WriteLine("Bilietai uz 30e spauskite - 3");
            Console.WriteLine("Ir iveskite ju kieki");
        }
        public void OperacijosParinkimas(int tipas, int kiekis, int pasirinkimas)
        {

            if (pasirinkimas == 1)
            {
                if (tipas == 1)
                    pirktiBilietus10(kiekis);
                if (tipas == 2)
                    pirktiBilietus20(kiekis);
                if (tipas == 3)
                    pirktiBilietus30(kiekis);
            }
            else if (pasirinkimas == 2)
            {
                if (tipas == 1)
                    BilietuPildymas10(kiekis);
                if (tipas == 2)
                    BilietuPildymas20(kiekis);
                if (tipas == 3)
                    BilietuPildymas30(kiekis);
            }

            UZbaigti();

        }

        public void UZbaigti()
        {
            Console.WriteLine("Pirkti dar bilietu? spauskite - 1");
            Console.WriteLine("Baigti? Spauskite - 2");
            int pasirinkimas = Convert.ToInt32(Console.ReadLine());

            if (pasirinkimas == 1)
            {
                PradziosPasirinkimas();
            }
            else if(pasirinkimas == 2)
            {
                Console.WriteLine("Darbas baigtas");
            }
        }

        public void BilietuPildymas10(int kiekis)
        {
            Bilietai10 = Bilietai10 + kiekis;
            Console.WriteLine(BilietaiIpilti);
        }
        public void BilietuPildymas20(int kiekis)
        {
            Bilietai20 = Bilietai20 + kiekis;
            Console.WriteLine(BilietaiIpilti);
        }
        public void BilietuPildymas30(int kiekis)
        {
            Bilietai30 = Bilietai30 + kiekis;
            Console.WriteLine(BilietaiIpilti);
        }

        public void pirktiBilietus10(int kiekis)
        {
            if (Bilietai10 >= kiekis)
            {
                Bilietai10 = Bilietai10 - kiekis;
                Ataskaita();
            }

            else Console.WriteLine(Nepakankamumas);
        }

        public void pirktiBilietus20(int kiekis)
        {
            if (Bilietai20 >= kiekis)
            {
                Bilietai20 = Bilietai20 - kiekis;
                Ataskaita();
            }

            else Console.WriteLine(Nepakankamumas);
        }

        public void pirktiBilietus30(int kiekis)
        {
            if (Bilietai30 >= kiekis)
            {
                Bilietai30 = Bilietai30 - kiekis;
                Ataskaita();
            }


            else Console.WriteLine(Nepakankamumas);
        }

        public void ParodytiTurimaBilietuKieki()
        {
            Console.WriteLine("Siuo metu bilietai kasoje:");
            Console.WriteLine("Tipas - 10 {0}", getBilietai10());
            Console.WriteLine("Tipas - 20 {0}", getBilietai20());
            Console.WriteLine("Tipas - 30 {0}", getBilietai30());
            Console.WriteLine("");
        }

        public void Ataskaita()
        {
            Console.WriteLine(GerosKeliones);
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

        public void ConsoleClear()
        {
            Console.Clear();
            ParodytiTurimaBilietuKieki();
        }

        public void PradziosPasirinkimas()
        {
            ParodytiTurimaBilietuKieki();
            ParodytiMeniu();

            int pasirinkimas = Convert.ToInt32(Console.ReadLine());
            if (pasirinkimas == 1)
            {
                ConsoleClear();
                RodytiTipus();
                OperacijosParinkimas(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), pasirinkimas);
            }
            else if (pasirinkimas == 2)
            {
                ConsoleClear();
                RodytiTipus();
                Console.WriteLine(PapildimoAprasas);
                OperacijosParinkimas(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), pasirinkimas);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BilietuApskaita ba = new BilietuApskaita();
            ba.PradziosPasirinkimas();
            Console.ReadLine();
        }

    }
}
