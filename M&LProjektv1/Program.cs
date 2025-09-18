using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
            menu();

            void menu()
            {
                Console.Clear();
                Console.WriteLine("Hej, velkommen til, du får nu muligheden for at spille 2 forskellige slags spil ");
                Console.WriteLine("\nDet ene er ´sten saks papir' lavet af Mads");
                Console.WriteLine("\nDet andet er 'Hangman' lavet af Ludvig");
                Console.WriteLine("\nTryk 1 for at spille sten saks papir, eller tryk 2 for Hangman");
                while (true)
                {
                    
                    int spillerValg;

                    string SpillerValg = Console.ReadLine();

                    if (SpillerValg == "1")
                    {
                        Console.Clear();
                        MadsSpil();
                        break;
                    }
                    if (SpillerValg == "2")
                    {
                        Console.Clear();
                        LudvigsSpil();
                    }
                    string input = Console.ReadLine()?.Trim().ToLower();

                    if (!int.TryParse(input, out spillerValg) || spillerValg < 0 || spillerValg > 2)
                    {

                        Console.WriteLine("Ugyldigt input! Du skal skrive 1 eller 2 ;)");

                        continue;
                    }

                    /* Console.WriteLine("Hej, velkommen til, du får nu muligheden for at spille 2 forskellige slags spil ");
                     Console.WriteLine("\nDet ene er ´sten saks papir' lavet af Mads");
                     Console.WriteLine("\nDet andet er 'Hangman' lavet af Ludvig");
                     Console.WriteLine("\nTryk 1 for at spille sten skas papir, eller tryk 2 for Hangman");
                     string SpillerValg = Console.ReadLine();
                     while (true)

                         if (SpillerValg == "1")
                             Console.WriteLine("dav");

                         else if (SpillerValg == "2")
                             LudvigsSpil();
                         else
                             Console.WriteLine("Du skrev ikke 1 eller 2, prøv igen");
                     */



                    menu();
                    void LudvigsSpil()
                    {



                        Console.WriteLine("velkommen til Hangman(lavet af Ludvig)"); //Lavet en velkomst til mit spil
                        Console.WriteLine(""); //bare for lidt plads

                        Console.WriteLine("Vælg en sværhedsgrad der går fra 1 til 3. eller du kan skrive menu for at komme tilbage til menuen");



                        HNGvalg(); //her starter jeg funktionen HNGvalg som er lavet til at vælge hvilken sværhedsgrad man skal i spillet. det er også her man kommer tilbage hvis man vil spille spillet igen

                        void HNGvalg()
                        {
                            bool HNGretry = true; // Det her er for at lave et loop, så hvis man skriver noget andet end det jeg vil have prøver man igen

                            while (HNGretry)
                            {
                                string HNGsvaerhedsgrad = Console.ReadLine(); //man indtaster sit indput som så bliver anvendt i switch casen
                                switch (HNGsvaerhedsgrad) // hver switch har en funktion af spillet som den køre. forskellen på spillene er kun de ord spillet kan gennemgå
                                {
                                    case "1":

                                        HNGspil1();


                                        break;
                                    case "2":
                                        HNGspil2();


                                        break;
                                    case "3":
                                        HNGspil3();


                                        break;
                                    case "menu":
                                        menu();

                                        break;

                                    default:
                                        Console.WriteLine("Du skrev ikke 1,2 eller 3, prøv igen");


                                        break;


                                }
                            } while (HNGretry == false) ; //for at lave lykken
                            

                        }
                        


                        //SPIL MED SVÆRHEDSGRAD 1--------------------------------------------------
                        void HNGspil1()
                        {

                            void HNGgaljen(int HNGforsoe) //Her er en funktion som producere spillets galje og laver et visuelt over ens ''liv''
                            {
                                if (HNGforsoe == 7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("O   |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("O   |");
                                    Console.WriteLine("|   |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|  |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|\\ |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|\\ |");
                                    Console.WriteLine("/   |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O   |");
                                    Console.WriteLine("/|\\  |");
                                    Console.WriteLine("/ \\  |");
                                    Console.WriteLine("    ===");
                                    Console.ResetColor();
                                }

                            }


                            string[] HNGord = new[] { "kaffe", "kage", "cykel", "danmark", "opgave", "ged", "hund", "kat", "sko", "salt", "stol", "sofa", "hest", "gris", "pasta" }; //Her har jeg lavet et Array med mine ord, og navngivet det HNGord hvor HNG er for at kategorisere spillets værdityper
                                                                                                                                                                                     //og så står der et tal ud foran HNGord og det er tilbage fra  da man valgte sværhedsgrad
                            string HNGordrnd = HNGord[new Random().Next(0, HNGord.Length - 1)]; //lavet en string som er alle de ord jeg lavede før, bare i en tilfældig rækkefølge
                            int HNGmaxliv = 7; // Her er spillerens maximale
                            int HNGliv = HNGmaxliv; //Her er ens nuværende liv som kommer til at falde hvis man gætter forkert

                            bool HNGvundet = false; //det her bruges senere til at finde ud af om man har vundet

                            List<char> HNGpcBukstaver = new List<char>(); //Det her er for at lave en liste, lidt som en prelavet array, men så man kan taste alle bukstaver ind fra alfabetet og det vil den bruge i spillet. 

                            while (HNGliv > 0 && !HNGvundet)  //så længe man har over 0 liv og man ikke har tabt, så vil man spille spillet
                            {
                                foreach (char HNGbukstav in HNGordrnd) //har lavet en foreach, som vil anvendes for hvert bukstav i ordet i spillet
                                {
                                    if (HNGpcBukstaver.Contains(HNGbukstav)) //hvis ens gæt er et bukstav i ordet så vil den skrive bukstavet
                                        Console.Write(HNGbukstav);
                                    else
                                        Console.Write("_"); //ellers vil den efterlade en flad streg som indikator på hvor mange bukstaver der er

                                }

                                Console.WriteLine("");

                                Console.WriteLine("Skriv et bukstav"); //information til spilleren
                                Console.WriteLine("du har " + HNGliv + " forsøg igen ");  //ja, det er så ens liv
                                HNGgaljen(HNGliv);


                                char HNGgaet = Convert.ToChar(Console.ReadLine());  //her er det spilleren indtaster sit gæt. men når man taster sit gæt in bliver det til en string, så har lavet en convert for at det kan blive en char og så sammenlignes med hvert af ordes char
                                                                                    //Problemet med det her er at man kun kan skrive char, har prøvet længe på at finde en løsning til hvordan den skulle sige ''skriv igen'' hvis man tastede en string ind. men gav op

                                if (HNGordrnd.Contains(HNGgaet) && !HNGpcBukstaver.Contains(HNGgaet)) //hvis spillets tilfældige ord indeholder ens gæt OG computerens bukstaver ikke indeholder ens gæt. så får man enten rigtig eller forkert og midster et liv
                                {
                                    Console.WriteLine("Det er rigtigt");
                                }
                                else

                                {
                                    Console.WriteLine("Det er forkert");
                                    HNGliv--;
                                }
                                HNGpcBukstaver.Add(HNGgaet); //Her så vil den tilføje det man skrev som sit gæt ind på List med PCbukstaver


                                bool HNGslut = true;// for at kunne afslute før man midster alle sine liv

                                foreach (char HNGbukstav in HNGordrnd) //kontrollere om alle bukstaverne er gættet
                                    if (!HNGpcBukstaver.Contains(HNGbukstav))
                                        HNGslut = false;

                                HNGvundet = HNGslut; //Laver det om til man har vundet hvis man havde gættet alt rigtigt


                            }


                            if (HNGvundet)
                                Console.WriteLine("Sådan, du vandt!");

                            else
                                Console.WriteLine("Øv, bedre held næste gang");




                            Console.WriteLine("");
                            Console.WriteLine("Nu hvor du er færdig, kunne du så tænke dig at spille igen eller retunere til menuen?");
                            Console.WriteLine("Skriv 'igen' for at spille igen eller skriv 'menu' for at gå til menuen");
                            string HNGdone = Console.ReadLine();
                            switch (HNGdone)//Her kommer der et valg om man vil spille igen eller om man vil tilbage til menuen
                            {
                                case "igen":
                                    Console.WriteLine("Vælg en sværhedsgrad der går fra 1 til 3. eller du kan skrive menu for at komme tilbage til menuen");
                                    HNGvalg();
                                    break;
                                case "menu":
                                    menu();
                                    break;
                            }
                            // tilføj switchen med menuen som er nederst på alle spil
                        }

                        //SPIL MED SVÆRHEDSGRAD 2---------------------------------------------------
                        void HNGspil2()
                        {

                            void HNGgaljen(int HNGforsoe) //Her er en funktion som producere spillets galje og laver et visuelt over ens ''liv''
                            {
                                if (HNGforsoe == 7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("O   |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("O   |");
                                    Console.WriteLine("|   |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|  |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|\\ |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|\\ |");
                                    Console.WriteLine("/   |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O   |");
                                    Console.WriteLine("/|\\  |");
                                    Console.WriteLine("/ \\  |");
                                    Console.WriteLine("    ===");
                                    Console.ResetColor();
                                }

                            }


                            string[] HNGord = new[] { "lektier", "chef", "elefant", "giraf", "tandpasta", "hundeslaede", "stationaer", "rynkeby", "termokop", "haandvask", "github" }; //Her har jeg lavet et Array med mine ord, og navngivet det HNGord hvor HNG er for at kategorisere spillets værdityper
                                                                                                                                                                                       //og så står der et tal ud foran HNGord og det er tilbage fra  da man valgte sværhedsgrad
                            string HNGordrnd = HNGord[new Random().Next(0, HNGord.Length - 1)]; //lavet en string som er alle de ord jeg lavede før, bare i en tilfældig rækkefølge
                            int HNGmaxliv = 6; // Her er spillerens maximale
                            int HNGliv = HNGmaxliv; //Her er ens nuværende liv som kommer til at falde hvis man gætter forkert

                            bool HNGvundet = false; //det her bruges senere til at finde ud af om man har vundet

                            List<char> HNGpcBukstaver = new List<char>(); //Det her er for at lave en liste, lidt som en prelavet array, men så man kan taste alle bukstaver ind fra alfabetet og det vil den bruge i spillet. 

                            while (HNGliv > 0 && !HNGvundet)  //så længe man har over 0 liv og man ikke har tabt, så vil man spille spillet
                            {
                                foreach (char HNGbukstav in HNGordrnd) //har lavet en foreach, som vil anvendes for hvert bukstav i ordet i spillet
                                {
                                    if (HNGpcBukstaver.Contains(HNGbukstav)) //hvis ens gæt er et bukstav i ordet så vil den skrive bukstavet
                                        Console.Write(HNGbukstav);
                                    else
                                        Console.Write("_"); //ellers vil den efterlade en flad streg som indikator på hvor mange bukstaver der er

                                }

                                Console.WriteLine("");

                                Console.WriteLine("Skriv et bukstav"); //information til spilleren
                                Console.WriteLine("du har " + HNGliv + " forsøg igen ");  //ja, det er så ens liv
                                HNGgaljen(HNGliv);


                                char HNGgaet = Convert.ToChar(Console.ReadLine());  //her er det spilleren indtaster sit gæt. men når man taster sit gæt in bliver det til en string, så har lavet en convert for at det kan blive en char og så sammenlignes med hvert af ordes char
                                                                                    //Problemet med det her er at man kun kan skrive char, har prøvet længe på at finde en løsning til hvordan den skulle sige ''skriv igen'' hvis man tastede en string ind. men gav op

                                if (HNGordrnd.Contains(HNGgaet) && !HNGpcBukstaver.Contains(HNGgaet)) //hvis spillets tilfældige ord indeholder ens gæt OG computerens bukstaver ikke indeholder ens gæt. så får man enten rigtig eller forkert og midster et liv
                                {
                                    Console.WriteLine("Det er rigtigt");
                                }
                                else

                                {
                                    Console.WriteLine("Det er forkert");
                                    HNGliv--;
                                }
                                HNGpcBukstaver.Add(HNGgaet); //Her så vil den tilføje det man skrev som sit gæt ind på List med PCbukstaver


                                bool HNGslut = true;// for at kunne afslute før man midster alle sine liv

                                foreach (char HNGbukstav in HNGordrnd) //kontrollere om alle bukstaverne er gættet
                                    if (!HNGpcBukstaver.Contains(HNGbukstav))
                                        HNGslut = false;

                                HNGvundet = HNGslut; //Laver det om til man har vundet hvis man havde gættet alt rigtigt


                            }


                            if (HNGvundet)
                                Console.WriteLine("Sådan, du vandt!");

                            else
                                Console.WriteLine("Øv, bedre held næste gang");




                            Console.WriteLine("");
                            Console.WriteLine("Nu hvor du er færdig, kunne du så tænke dig at spille igen eller retunere til menuen?");
                            Console.WriteLine("Skriv 'igen' for at spille igen eller skriv 'menu' for at gå til menuen");
                            string HNGdone = Console.ReadLine();
                            switch (HNGdone)//Her kommer der et valg om man vil spille igen eller om man vil tilbage til menuen
                            {
                                case "igen":
                                    Console.WriteLine("Vælg en sværhedsgrad der går fra 1 til 3. eller du kan skrive menu for at komme tilbage til menuen");
                                    HNGvalg();
                                    break;
                                case "menu":
                                    menu();
                                    break;
                            }
                            // tilføj switchen med menuen som er nederst på alle spil
                        }
                        //SPIL med sværhedsgrad 3!!!-------------------------------------------------------------------------------
                        void HNGspil3()
                        {

                            void HNGgaljen(int HNGforsoe) //Her er en funktion som producere spillets galje og laver et visuelt over ens ''liv''
                            {
                                if (HNGforsoe == 7)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("O   |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine("O   |");
                                    Console.WriteLine("|   |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|  |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|\\ |");
                                    Console.WriteLine("    |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O  |");
                                    Console.WriteLine("/|\\ |");
                                    Console.WriteLine("/   |");
                                    Console.WriteLine("   ===");
                                    Console.ResetColor();
                                }
                                else if (HNGforsoe == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n+---+");
                                    Console.WriteLine(" O   |");
                                    Console.WriteLine("/|\\  |");
                                    Console.WriteLine("/ \\  |");
                                    Console.WriteLine("    ===");
                                    Console.ResetColor();
                                }

                            }


                            string[] HNGord = new[] { "astronaut", "elevatorskakt", "accellerere", "financiere", "diciplin", "ministerie", "pencillin", "reflektion", "staniol", "allesammen", "medlemsskab", "checke", "kontrollere", "anderkendelse", "microsoftvision" }; //Her har jeg lavet et Array med mine ord, og navngivet det HNGord hvor HNG er for at kategorisere spillets værdityper
                                                                                                                                                                                                                                                                             //og så står der et tal ud foran HNGord og det er tilbage fra  da man valgte sværhedsgrad
                            string HNGordrnd = HNGord[new Random().Next(0, HNGord.Length - 1)]; //lavet en string som er alle de ord jeg lavede før, bare i en tilfældig rækkefølge
                            int HNGmaxliv = 6; // Her er spillerens maximale
                            int HNGliv = HNGmaxliv; //Her er ens nuværende liv som kommer til at falde hvis man gætter forkert

                            bool HNGvundet = false; //det her bruges senere til at finde ud af om man har vundet

                            List<char> HNGpcBukstaver = new List<char>(); //Det her er for at lave en liste, lidt som en prelavet array, men så man kan taste alle bukstaver ind fra alfabetet og det vil den bruge i spillet. 

                            while (HNGliv > 0 && !HNGvundet)  //så længe man har over 0 liv og man ikke har tabt, så vil man spille spillet
                            {
                                foreach (char HNGbukstav in HNGordrnd) //har lavet en foreach, som vil anvendes for hvert bukstav i ordet i spillet
                                {
                                    if (HNGpcBukstaver.Contains(HNGbukstav)) //hvis ens gæt er et bukstav i ordet så vil den skrive bukstavet
                                        Console.Write(HNGbukstav);
                                    else
                                        Console.Write("_"); //ellers vil den efterlade en flad streg som indikator på hvor mange bukstaver der er

                                }

                                Console.WriteLine("");

                                Console.WriteLine("Skriv et bukstav"); //information til spilleren
                                Console.WriteLine("du har " + HNGliv + " forsøg igen ");  //ja, det er så ens liv
                                HNGgaljen(HNGliv);


                                char HNGgaet = Convert.ToChar(Console.ReadLine());  //her er det spilleren indtaster sit gæt. men når man taster sit gæt in bliver det til en string, så har lavet en convert for at det kan blive en char og så sammenlignes med hvert af ordes char
                                                                                    //Problemet med det her er at man kun kan skrive char, har prøvet længe på at finde en løsning til hvordan den skulle sige ''skriv igen'' hvis man tastede en string ind. men gav op

                                if (HNGordrnd.Contains(HNGgaet) && !HNGpcBukstaver.Contains(HNGgaet)) //hvis spillets tilfældige ord indeholder ens gæt OG computerens bukstaver ikke indeholder ens gæt. så får man enten rigtig eller forkert og midster et liv
                                {
                                    Console.WriteLine("Det er rigtigt");
                                }
                                else

                                {
                                    Console.WriteLine("Det er forkert");
                                    HNGliv--;
                                }
                                HNGpcBukstaver.Add(HNGgaet); //Her så vil den tilføje det man skrev som sit gæt ind på List med PCbukstaver


                                bool HNGslut = true;// for at kunne afslute før man midster alle sine liv

                                foreach (char HNGbukstav in HNGordrnd) //kontrollere om alle bukstaverne er gættet
                                    if (!HNGpcBukstaver.Contains(HNGbukstav))
                                        HNGslut = false;

                                HNGvundet = HNGslut; //Laver det om til man har vundet hvis man havde gættet alt rigtigt


                            }


                            if (HNGvundet)
                                Console.WriteLine("Sådan, du vandt!");

                            else
                                Console.WriteLine("Øv, bedre held næste gang");




                            Console.WriteLine("");
                            Console.WriteLine("Nu hvor du er færdig, kunne du så tænke dig at spille igen eller retunere til menuen?");
                            Console.WriteLine("Skriv 'igen' for at spille igen eller skriv 'menu' for at gå til menuen");
                            string HNGdone = Console.ReadLine(); // tilføj switchen med menuen som er nederst på alle spil


                            switch (HNGdone) //Her kommer der et valg om man vil spille igen eller om man vil tilbage til menuen
                            {
                                case "igen":
                                    Console.WriteLine("Vælg en sværhedsgrad der går fra 1 til 3. eller du kan skrive menu for at komme tilbage til menuen");
                                    HNGvalg();
                                    break;
                                case "menu":
                                    menu();
                                    break;
                               
                            }
                        }





                    }
                }
            }
            //Mads spil
            //----------------------------------------------------
            
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
                    if (input == "menu") 
                    {
                        menu();
                            }
                    


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
