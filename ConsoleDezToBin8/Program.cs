﻿using System;
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
                int nDez = Convert.ToInt32(strDez);
                string strBin = "";

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
                
                Console.Write("Die Darstellung im Binärsystem lautet: ");
                Console.WriteLine(strBin);
                Console.Write("Programm be(e)nden? ");
                strEnde = Console.ReadLine();
            }                    
        }
    }
}

