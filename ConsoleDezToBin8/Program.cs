using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDezToBin8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            Console.WriteLine("ConsoleDezToBin8");

            string strEnde = "";
            while (strEnde != "e")
            {
                Console.Write("\nBitte eine Zahl im Dezimalsystem eingeben (0..255): ");
                string strDez = Console.ReadLine();
                
                string strBin = DezToBin8(strDez);

                Console.Write("Die Darstellung im Binärsystem lautet: ");
                Console.WriteLine(strBin);

                Console.Write("Programm be(e)nden? ");
                strEnde = Console.ReadLine();
            }
        }

        private static string DezToBin8(string strDez)
        {
            string strBin = "";
            int nDez = Convert.ToInt32(strDez);

            if ((nDez < 256) && (nDez >= 0))
            {
                int nMod = 0;
                int nDiv = nDez;

                for (int i = 0; i < 8; i++)
                {
                    nMod = nDiv % 2;
                    nDiv = nDiv / 2;
                    strBin = nMod + strBin;
                }
            }
            else if (nDez > 255)
                strBin = "Fehler, Zahl zu groß!";
            else
                strBin = "Fehler, Zahl zu klein!";

            return strBin;
        }
    }
}

