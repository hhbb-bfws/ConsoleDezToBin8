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
            Console.WriteLine();

            string strEnde = "";
            while (strEnde != "e")
            {
                Console.Write("Bitte geben Sie eine Zahl im Dezimalsystem ein (0..255): ");
                string strDez = Console.ReadLine();
                int nDez = Convert.ToInt32(strDez);

                int nMod = 0;
                int nDiv = nDez;
                string strBin = "";

                for (int i = 0; i < 8; i++)
                {
                    nMod = nDiv % 2;
                    nDiv = nDiv / 2;
                    strBin = nMod + strBin;
                }

                Console.Write("Die Darstellung im Binärsystem lautet: ");
                Console.WriteLine(strBin);
                Console.Write("\nProgramm be(e)nden? ");
                strEnde = Console.ReadLine();
            }                    
        }
    }
}

