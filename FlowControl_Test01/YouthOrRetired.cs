namespace FlowControl_Test01
{
    internal class YouthOrRetired
    {
        int singleAge;
        public YouthOrRetired()
        {
            Console.Clear();
            Console.WriteLine("\n.: Ungdom eller pensionär :.");
            Console.WriteLine("\n  Välkommen till biografen BioLogik.");

            do
            {
                Console.WriteLine("\n  Du har följande val:");
                Console.WriteLine(" - Skriv in din ålder för att få reda på biljettpriset för just dig.");
                Console.WriteLine(" - För att räkna ut priset för ett större sällskap skriv s.");
                Console.WriteLine(" - För att återgå till huvudmenyn skriv m.");
                Console.Write("\nDitt val: ");
                string input = Console.ReadLine();
                bool success = int.TryParse(input, out singleAge);

                if (success == true)
                {
                    MovieOneTicket enkelBiljett = new MovieOneTicket(singleAge);
                }
                else if (input == "m")
                {
                    MainMenu mainMenu = new MainMenu();
                }
                else if (input == "s")
                {
                    MovieManyTickets fleraBiljetter = new MovieManyTickets();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n- Det du skrev in faller utanför de ramar jag satte upp. Jag är besviken på dig.. -\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (true);



        }

    }
}