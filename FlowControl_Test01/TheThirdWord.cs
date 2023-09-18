namespace FlowControl_Test01
{
    internal class TheThirdWord
    {
        public TheThirdWord()
        {

            /*
             * Här får man i uppgift att skriva in en mening på minst tre ord, där datorn skriver ut det tredje ordet.
             * Det går även bra att skriva in m för att återgå till huvudmenyn.
             * 
             * Jag har byggt upp allt med en while-loop.
             * 
             *   Där tittar jag först på om användaren skrivit m.
             *   
             *   Efter det delas string-värdet upp baserat på mellanslag.
             *   
             *   En if-sats ger ett felmeddelande om det användaren skrivit in är kortare än 3 ord.
             *   
             *   Om meningen är tillräckligt lång skrivs det trejde ordet ut och efteråt körs while-loopen om och användaren
             *   kan spela igen eller hoppa tillbaka till huvudmenyn.
             * 
             */


            Console.Clear();
            Console.WriteLine(".: Det tredje ordet :.");
            Console.WriteLine("\n  Välkommen till den roliga leken Det tredje ordet.");
            Console.WriteLine("  Leken går till så att du skriver en mening med minst 3 ord.");
            Console.WriteLine("  Sen blir min uppgift att försöka lista ut vilket ord i din mening som är det tredje ordet!");

            do
            {
                Console.Write("\nSkriv här: ");
                string thirdWord = Console.ReadLine();

                if (thirdWord == "m")
                {
                    //Hoppar till MainMenu om man skriver in m
                    MainMenu mainMenu = new MainMenu();
                }

                //Delar upp strängen baserat på meningens mellanrum.
                var result = thirdWord.Split(' ');


               
                if (result.Length < 3)
                {
                    
                    // Om arrayen är mindre än tre på grund av att meningen inte hade fler ord
                    // får man ett felmeddelande innan do-while körs om igen
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n- Meningen du skriver in behöver vara på minst tre ord. -\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }   
                else
                {
                    // När användaren skrivit rätt skrivs det tredje ordet ut på skärmen
                    // Efteråt får användare information om att det går bra att spela igen eller hoppa till MainMenu
                    Console.WriteLine($"\nDet tredje ordet i din mening var '{result[2]}'.");

                    Console.WriteLine($"\n  Du kan spela igen genom att skriva in en mening på minst 3 ord.");
                    Console.WriteLine($"  Skriv m om du vill hoppa tillbaka till huvudmenyn.");
                }
                 
            } while (true);                       
        }
    }
}