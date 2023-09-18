namespace FlowControl_Test01
{
    internal class MovieManyTickets
    {
        /*
         * Här får direkt användaren frågan om hur många som ska gå på bio.
         * 
         * En if-sats konverterar strängen till en int, så länge användaren skrivit in en siffra.
         * Om användaren skrivit in något annat än en siffra kommer ett felmeddelande och ett nytt försök att skriva rätt.
         * 
         * När antalet besökare angivits skickas körs en funktion där användaren får skriva in en ålder per besökare.
         * 
         * Antalet besökare skickasn in i ny metod
         * I metoden körs en for-loop som körs till for-loopens värde är detsamma som antalet besökare.
         * 
         * Varje gång en ålder skrivs in så körs en metod som returnerar ett biljettpris baserat på åldern som skrivits in.
         * Det returnerade värdet adderas till variabeln totSum.
         * 
         * När for-loopen körts klart och åldern på alla besökare skrivits in är värdet i totSum det totala värdet som ska betalas.
         * 
         */

        public MovieManyTickets()
        {

            int numVisitors;

            Console.WriteLine("\nSkriv in hur många ni är som ska gå på bio.");
            Console.Write("\n  Antal besökare: ");

            do
            {
                string strVisitors = Console.ReadLine();

                if (int.TryParse(strVisitors, out numVisitors))
                {
                    //När antalet besökare bestämts körs här metoden AllVisitorsAge för att bestämma ålder på alla besökare.
                    AllVisitorsAge(numVisitors);
                    YouthOrRetired youthOrRetired = new YouthOrRetired(); 
                }

                else
                {
                    //Om input från användaren inte är ett heltal får användaren ett felmeddelande och (tack vare while-loopen) en ny chans att skriva in ett korrekt värde.
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n- Du måste skriva in en siffra för att jag ska veta hur många besökare ni är. -\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n  Skriv in antalet biobesökare: ");
                }

            } while (true);

        }

        private void AllVisitorsAge(int numVisitors)
        {
            int ageOfPerson;
            int totSum = 0;

            for (int i = 1; i < numVisitors;)            
            {
                do
                {
                    Console.Write($"\n  Skriv in åldern på besökare {i}: ");
                    string ageUserInput= Console.ReadLine();

                    if (int.TryParse(ageUserInput, out ageOfPerson))
                    {
                        // Så länge användare skriver in ett heltal körs metoden CalcPrice för att returnera priset på biljetten för den personen.
                        CalcPrice(ageOfPerson);
                        var returnedValue = CalcPrice(ageOfPerson);
                        totSum = totSum + returnedValue;                        

                        // Här adderas även 1 till for-loopens int så den vet att priset för en besökare nu räknats ut.
                        i++;                        
                    }

                    else
                    {
                        // Om användaren skriver in något annat än en int kommer ett felmeddelande och loopen körs om utan i++
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n- Följ instruktionerna, annars missar ni filmen. -\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                } while (i != numVisitors+1);

                //Här skrivs summan av alla biljetter ut och användaren kan trycka enter för att återgå till biosalongens meny.

                Console.WriteLine($"\nPriset för biljetter till ert sällskap är {totSum}kr");
                Console.WriteLine($"\n  Tryck enter för att återgå till biograf BioLogiks huvudmeny.");
                Console.ReadLine();
                YouthOrRetired youthOrRetired = new YouthOrRetired();
            }
                       
        }

        internal int CalcPrice(int calculatePrice)
        {

            /* Hit skickas åldern på varje besökare för att bestämma vad biljettpriset blir baserat på just åldern.
             * Värdet som returneras är värdet på biljetten som sedan kan adderas till det totala biljettpriset.
             * */

            if (calculatePrice < 5 || calculatePrice > 100)
            {
                return 0;
            }
            
            if (calculatePrice >= 5 & calculatePrice < 20) 
            {
                return 80;

            }
            
            if (calculatePrice >= 20 & calculatePrice < 65 ) 
            {
                return 120;
            }
            
            if (calculatePrice >= 65 & calculatePrice <= 100 ) 
            {
                return 90;
            }                        
            return 0;            
        }
    }
}