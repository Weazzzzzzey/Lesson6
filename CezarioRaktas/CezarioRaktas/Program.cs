using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CezarioRaktas
{
    public class Cz
    {



        public string UzKodavimas(string Zodis, string Raktas)
        {
            char[] tempZodis = Zodis.ToArray();
            char[] tempRaktas = Raktas.ToArray();

            int j = 0;
            for (int i = 0; i < tempZodis.Length; i++)
            {
                int raktoK = tempRaktas[j];
                j = j + 1;
                if (j == 3)
                {
                    j = 0;
                }

                int sk = tempZodis[i];
                int uzkoduotas = sk + raktoK;
                tempZodis[i] = (char)uzkoduotas;

            }

            string done = "";
            foreach (var item in tempZodis)
            {
                done = done + item;
            }

            return done;

        }

        public string dekodavimas(string Zodis, string Raktas)
        {
            char[] tempZodis = Zodis.ToArray();
            char[] tempRaktas = Raktas.ToArray();

            int j = 0;
            for (int i = 0; i < tempZodis.Length; i++)
            {
                int raktoK = tempRaktas[j];
                j = j + 1;
                if (j == 3)
                {
                    j = 0;
                }

                int sk = tempZodis[i];
                int uzkoduotas = sk - raktoK;
                tempZodis[i] = (char)uzkoduotas;

            }

            string done = "";

            foreach (var item in tempZodis)
            {
                done = done + item;
            }

            return done;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Cz Kod = new Cz();
            Console.WriteLine(Kod.UzKodavimas("ABCDEF", "VIP"));
            Console.WriteLine(Kod.dekodavimas(Kod.UzKodavimas("ABCDEF", "VIP"),"VIP"));
            Console.Read();
        
        }
    }
}
