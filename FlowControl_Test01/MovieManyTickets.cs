namespace FlowControl_Test01
{
    internal class MovieManyTickets
    {

        public MovieManyTickets()
        {

            int numVisitors;


            Console.WriteLine("\nSkriv in hur många ni är som ska gå på bio.");
            Console.Write("\n  Antal besökare: ");

            do
            {
                string strVisitors = Console.ReadLine();
                bool success = int.TryParse(strVisitors, out numVisitors);

                if (success == true)
                {
                    AllVisitorsAge(numVisitors);
                    YouthOrRetired youthOrRetired = new YouthOrRetired(); 
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n- Du måste skriva in en siffra för att jag ska veta hur många besökare ni är.-\n");
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
                        //matematik
                        CalcPrice(ageOfPerson);
                        var returnedValue = CalcPrice(ageOfPerson);
                        totSum = totSum + returnedValue;
                        //Console.WriteLine(totSum);
                        i++;
                        
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\n- Följ instruktionerna, annars missar ni filmen.\n");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                } while (i != numVisitors+1);

                Console.WriteLine($"\nPriset för biljetter till ert sällskap är {totSum}kr");
                Console.WriteLine($"\n  Tryck enter för att återgå till biograf BioLogiks huvudmeny.");
                Console.ReadLine();
                YouthOrRetired youthOrRetired = new YouthOrRetired();
            }
                       
        }

        internal int CalcPrice(int calculatePrice)
        {

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