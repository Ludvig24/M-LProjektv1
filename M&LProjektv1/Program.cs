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

            string[] HNGord = new[] {"kaffe", "Kage", "cykel", "Danmark", "opgave"}; //Her har jeg lavet et Array med mine ord, og navngivet det HNGord hvor HNG er for at kategorisere spillets værdityper
            string HNGordrnd = HNGord[new Random().Next(0, HNGord.Length)];

            int HNGmaxliv = 5; // kan justeres
            int HNGliv = HNGmaxliv;

            bool HNGvundet = false; //kan være jeg sletter

            List<char> HNGskud = new List<char>();

            while (HNGliv >=0 && ) 
            {
                foreach (char HNGbukstav in HNGordrnd)
                {
                    if (HNGskud.Contains(HNGbukstav))
                        Console.Write(HNGbukstav);
                    else
                        Console.Write("_");

                }
                Console.WriteLine("");
                Console.WriteLine("gæt et tal");
                Console.WriteLine("du har " + HNGliv + " forsøg igen ");
               

                char HNGgaet = Convert.ToChar(Console.ReadLine());

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
            }
                    






            // skal huske at have en mulighed for at kunne retunere til menuen










            //MADS SPIL 




        }
        
    }
}
