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
            //Introduktion




            Console.WriteLine("hej");



            //LUDVIGS SPIL HNG = er hvad jeg skriver foran mine funktioner og værdityper

            //velkomst besked

            // et flow-control om hvordan man vælger sit ord, nok med nogle funktioner for at gøre det lækkert




            // selve spillet, gerne nogle funktioner om hvordan man gætter et bukstav og så bruger et forsøg
            //Note til mig selv, lav ordet til upper eller lower case.
            //adgang til menu
            //flere ord, måske lav spillet om til en funktion og eller hverrtfald gør så man kian vælge mellem flere ord

            string[] HNGord = new[] {"kaffe", "kage", "cykel", "danmark", "opgave"}; //Her har jeg lavet et Array med mine ord, og navngivet det HNGord hvor HNG er for at kategorisere spillets værdityper
            string HNGordrnd = HNGord[new Random().Next(0, HNGord.Length)]; //lavet en string som er alle de ord jeg lavede før, bare i en tilfældig rækkefølge

            int HNGmaxliv = 5; // Her er spillerens maximale liv, kan justeres
            int HNGliv = HNGmaxliv; //Her er ens nuværende liv som kommer til at falde hvis man gætter forkert

            bool HNGvundet = false; //det her bruges senere til at finde ud af om man har vundet

            List<char> HNGskud = new List<char>(); //Det her er for at lave en liste, lidt som en prelavet array, men så man kan taste alle bukstaver ind fra alfabetet og det vil den bruge i spillet. hedder skud for det ens forsøg

            while (HNGliv >0 && !HNGvundet)  //så længe man har over 0 liv og man ikke har tabt, så vil man spille spillet
            {
                foreach (char HNGbukstav in HNGordrnd) //har lavet en foreach, som vil anvendes for hvert bukstav i ordet i spillet
                {
                    if (HNGskud.Contains(HNGbukstav)) //hvis ens gæt er et bukstav i ordet så vil den skrive bukstavet
                        Console.Write(HNGbukstav);
                    else
                        Console.Write("_"); //ellers vil den efterlade en flad streg som indikator på hvor mange bukstaver der er

                }
                Console.WriteLine("");
                Console.WriteLine("gæt et tal"); //information til spilleren
                Console.WriteLine("du har " + HNGliv + " forsøg igen ");  //ja, det er så ens liv
               

                char HNGgaet = Convert.ToChar(Console.ReadLine());  //her er det spilleren indtaster sit gæt. men når man taster sit gæt in bliver det til en string, så har lavet en convert for at det kan blive en char og så sammenlignes med hvert af ordes char

                if (HNGordrnd.Contains(HNGgaet) && !HNGskud.Contains(HNGgaet)) 
                {
                    Console.WriteLine("Det er rigtigt");
                }
                else

                {
                    Console.WriteLine("Det er forkert");
                    HNGliv--;
                }
                HNGskud.Add(HNGgaet);


                bool HNGslut = false;

                foreach(char HNGbukstav in HNGordrnd)
                if (!HNGskud.Contains(HNGgaet))
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
