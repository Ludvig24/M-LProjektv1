using System;
using System.Collections.Generic;
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

            Console.WriteLine(" Her skal du gætte et ord på 4 bukstaver");

            string[,] HNGord1 = new string[4, 1];
            HNGord1[0, 0] = "_ ";
            HNGord1[1, 0] = "_ ";
            HNGord1[2, 0] = "_ ";
            HNGord1[3, 0] = "_ ";
            for (int i = 0; i < HNGord1.Length; i++)
            {
                Console.Write(HNGord1[i, 0]);
            }


            for (int HNGraekke = 0; HNGraekke < 3; HNGraekke++)
            {
                for (int HNGkollone = 0; HNGkollone < 0; HNGkollone++)
                {
                    HNGord1[HNGraekke, HNGkollone] = "_";
                }

            }



            // skal huske at have en mulighed for at kunne retunere til menuen










            //MADS SPIL 




        }
        
    }
}
