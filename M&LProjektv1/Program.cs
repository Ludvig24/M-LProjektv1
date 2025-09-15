using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace M_LProjektv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Introduktion





        }
        { //LUDVIGS SPIL HNG

        }



}

{ //MADS SPIL 

    Console.WriteLine("Velkommen til Sten Saks Papir");
    Console.WriteLine("Skriv dit valg 0 = Sten, 1 = Saks, 2 = Papir");
    Console.Write("Dit valg er");

    int spillerValg = int.Parse(Console.ReadLine());//int.parse = Prøv at lave teksten om til et helt tal (int)
                                                    //Programmet venter på, at spilleren skriver noget.
                                                    //Det, spilleren skriver, bliver gemt som tekst.
                                                    //int.Parse prøver at lave teksten om til et heltal.
                                                    //Til sidst bliver tallet gemt i variablen spi

    Random rnd = new Random();

    int computerValg = rnd.Next(0, 3);

    string[] valgNavne = { "Sten", "Saks", "Papir" };

    //Viser spillernes valg

    Console.WriteLine($"Du valgte: {valgNavne[spillerValg]}");
    Console.WriteLine($"Computeren valgte: {valgNavne[computerValg]}");


    //Finder en vinder

    if (spillerValg == computerValg)
    {
        Console.WriteLine("Det blev uafgjort!");
    }

    else if ((spillerValg == 0 && computerValg == 1) || //Sten slår saks
            (spillerValg == 1 && computerValg == 2) || //Saks slår papir
            (spillerValg == 2 && computerValg == 0)) //Papir slår sten

    {
        Console.WriteLine("Du vandt!");
    }


    else

    {
        Console.WriteLine("Computeren vandt");
    }


    }

    }
}

        
    
