using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace M_LProjektv1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MadsSpil();
            void MadsSpil()
            {
                int spillerPoint = 0; //Spillerens point
                int computerPoint = 0; // Computerens point
                int spillerValg;

                while (true) // en løkke, så spillet kører, indtil vi trykker på en bestemt tast
                {

                    Console.WriteLine("Velkommen til Sten Saks Papir");

                    Console.WriteLine();

                    Console.Write("Skriv dit valg 0 = Sten, 1 = Saks, 2 = Papir, tryk derefter enter.");

                    Console.Write("Dit valg er");


                    ;//int.parse = Prøver at lave teksten om til et helt tal (int)
                     //Programmet venter på, at spilleren skriver noget.
                     //Det, spilleren skriver, bliver gemt som tekst.
                     //int.Parse prøver at lave teksten om til et heltal.
                     //Til sidst bliver tallet gemt i variablen spillerValg

                    Random rnd = new Random();

                    int computerValg = rnd.Next(0, 3);

                    string[] valgNavne = { "Sten", "Saks", "Papir" };

                    //Viser spillernes valg



                    string input = Console.ReadLine()?.Trim().ToLower();

                    // Stop spillet hvis brugeren skriver 'q'
                    // eller loader vores menu/oversigt, hvis man skriver menu
                    if (input == "q") break;
                    if (input == "menu") ;
                    menu();


                    // Deklarér spillerValg én gang udenfor TryParse
                    if (!int.TryParse(input, out spillerValg) || spillerValg < 0 || spillerValg > 2)
                    {
                        Console.WriteLine("Ugyldigt input! Du skal skrive 0, 1 eller 2 ;)");
                        continue;
                    }
                    Console.WriteLine($"Du valgte: {valgNavne[spillerValg]}");
                    Console.WriteLine($"Computeren valgte: {valgNavne[computerValg]}");



                    //Finder en vinder


                    if (spillerValg == computerValg)// hvis spillerens valg er det samme som computerens
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Det blev uafgjort!");
                        Console.ResetColor();// Farven bliver resettet, så det kun er teksten
                                             // for resultatet, der farves
                    }

                    else if ((spillerValg == 0 && computerValg == 1) || //Sten slår saks
                            (spillerValg == 1 && computerValg == 2) || //Saks slår papir
                            (spillerValg == 2 && computerValg == 0)) //Papir slår sten

                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Du vandt!");
                        Console.ResetColor();//Så linjen efter ikke også bliver grøn
                        spillerPoint++; //Point til spiller
                    }


                    else

                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Computeren vandt!");
                        Console.ResetColor();
                        computerPoint++;
                    }

                    {
                        Console.WriteLine($"\nScore: Du {spillerPoint} - {computerPoint} Computeren"); //viser løbende pointstillingen

                    }

                }
            }
        }
    }
} 



    


        
    
