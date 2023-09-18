namespace FlowControl_Test01
{
    internal class RepeatTenTimes
    {
        /* Klassen börjar att rensa skärmen och skriver sedan en förklaring om vad man ska göra.
         * 
         * Sen hamnar man i en while loop med en switch där användaren får skriva något.
         * 
         *    Om användaren skriver "m" så återgår programmet till huvudmenyn.
         *    
         *    Om användaren skriver något annat körs en metod som repeterar det användaren skrev på samma rad 10 gånger med repetitionen som prefix.
         * 
         */
        public RepeatTenTimes()
        {
            Console.Clear();
            Console.WriteLine(".: Upprepa 10 gånger :.");
            Console.WriteLine("\n  Välkommen till denna väldigt roliga lek.");
            Console.WriteLine("\n  Leken går till så att du skriver någonting.. vad som helst!\n  (Förutom m som tar dig tillbaka till huvudmenyn).");
            Console.WriteLine("\n  Jag kommer sedan repetera det du skrev 10 gånger\n  efter varandra och dessutom numrera varje upprepning!");
            do                
            {
                Console.Write("\nSkriv något: ");
                string vadSomHelst = Console.ReadLine();
                Console.WriteLine("");

                switch (vadSomHelst)
                {
                    //m tar alltid användaren tillbaka till huvudmenyn.
                    case "m":                        
                        MainMenu mainMenu = new MainMenu();
                        break;

                    //allt annat som användaren skriver gör så att metoden denRoligaLeken körs.
                    default:
                        denRoligaLeken(vadSomHelst);
                        break;
                }

            } while (true);
        }
        //Det här är metoden som repeterar det användaren skrivit. Allt skrivs på samma rad med repetitionen som prefix till strängen som användaren skrev.
        internal void denRoligaLeken(string userInput)
        {
            Console.Write("  ");
            for (int i = 1; i < 11; i++)
            {
                Console.Write($"{i}.{userInput}");

                if (i <= 9)
                {
                    //mellan varje upprepning skrivs ett ,-tecken in.
                    Console.Write(", ");
                }
                else
                {
                    //efter den sista upprepningen avslutas raden med en punkt.
                    Console.Write(".");
                }
            }
            Console.WriteLine("\n\n  Skriv gärna något mer för att leka igen!");
            Console.WriteLine("  (Förutom m då. Det tar dig som vanligt tillbaka till huvudmenyn)");
        }
    }
}