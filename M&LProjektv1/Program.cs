using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M_LProjektv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("velkommen til Hangman(lavet af Ludvig");
            Console.WriteLine("");



             void HNGgaljen(int HNGforsoe)
            {
                if (HNGforsoe == 6)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("    |");
                    Console.WriteLine("    |");
                    Console.WriteLine("    |");
                    Console.WriteLine("   ===");
                }
                else if (HNGforsoe == 5)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("O   |");
                    Console.WriteLine("    |");
                    Console.WriteLine("    |");
                    Console.WriteLine("   ===");
                }
                else if (HNGforsoe == 4)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine("O   |");
                    Console.WriteLine("|   |");
                    Console.WriteLine("    |");
                    Console.WriteLine("   ===");
                }
                else if (HNGforsoe == 3)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine(" O  |");
                    Console.WriteLine("/|  |");
                    Console.WriteLine("    |");
                    Console.WriteLine("   ===");
                }
                else if (HNGforsoe == 2)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine(" O  |");
                    Console.WriteLine("/|\\ |");
                    Console.WriteLine("    |");
                    Console.WriteLine("   ===");
                }
                else if (HNGforsoe == 2)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine(" O  |");
                    Console.WriteLine("/|\\ |");
                    Console.WriteLine("/   |");
                    Console.WriteLine("   ===");
                }
                else if (HNGforsoe == 1)
                {
                    Console.WriteLine("\n+---+");
                    Console.WriteLine(" O   |");
                    Console.WriteLine("/|\\  |");
                    Console.WriteLine("/ \\  |");
                    Console.WriteLine("    ===");
                }

            }
            string[] HNGord = new[] { "kaffe", "kage", "cykel", "danmark", "opgave" }; //Her har jeg lavet et Array med mine ord, og navngivet det HNGord hvor HNG er for at kategorisere spillets værdityper
            string HNGordrnd = HNGord[new Random().Next(0, HNGord.Length - 1)]; //lavet en string som er alle de ord jeg lavede før, bare i en tilfældig rækkefølge

            int HNGmaxliv = 6; // Her er spillerens maximale liv, kan justeres
            int HNGliv = HNGmaxliv; //Her er ens nuværende liv som kommer til at falde hvis man gætter forkert

            bool HNGvundet = false; //det her bruges senere til at finde ud af om man har vundet

            List<char> HNGpcbukstaver = new List<char>(); //Det her er for at lave en liste, lidt som en prelavet array, men så man kan taste alle bukstaver ind fra alfabetet og det vil den bruge i spillet. hedder skud for det ens forsøg

            while (HNGliv > 0 && !HNGvundet)  //så længe man har over 0 liv og man ikke har tabt, så vil man spille spillet
            {
                foreach (char HNGbukstav in HNGordrnd) //har lavet en foreach, som vil anvendes for hvert bukstav i ordet i spillet
                {
                    if (HNGpcbukstaver.Contains(HNGbukstav)) //hvis ens gæt er et bukstav i ordet så vil den skrive bukstavet
                        Console.Write(HNGbukstav);
                    else
                        Console.Write("_"); //ellers vil den efterlade en flad streg som indikator på hvor mange bukstaver der er

                }
                
                Console.WriteLine("");
              
                Console.WriteLine("Skriv et bukstav"); //information til spilleren
                Console.WriteLine("du har " + HNGliv + " forsøg igen ");  //ja, det er så ens liv
                HNGgaljen(HNGliv);


                char HNGgaet = Convert.ToChar(Console.ReadLine());  //her er det spilleren indtaster sit gæt. men når man taster sit gæt in bliver det til en string, så har lavet en convert for at det kan blive en char og så sammenlignes med hvert af ordes char

                if (HNGordrnd.Contains(HNGgaet) && !HNGpcbukstaver.Contains(HNGgaet))
                {
                    Console.WriteLine("Det er rigtigt");
                }
                else

                {
                    Console.WriteLine("Det er forkert");
                    HNGliv--;
                }
                HNGpcbukstaver.Add(HNGgaet);


                bool HNGslut = true;

                foreach (char HNGbukstav in HNGordrnd)
                    if (!HNGpcbukstaver.Contains(HNGbukstav))
                        HNGslut = false;

                HNGvundet = HNGslut;


            }

            if (HNGvundet)
                Console.WriteLine("Sådan, du vandt!");

            else
                Console.WriteLine("Øv, bedre held næste gang");





            // skal huske at have en mulighed for at kunne retunere til menuen










            //MADS SPIL 








        }

    }
}
