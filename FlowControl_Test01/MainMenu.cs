namespace FlowControl_Test01
{
    internal class MainMenu
    {
        public MainMenu()
        {
            /*
             * Den här klassen körs direkt när programmet startar och börjar med att
             * skriva ut information om vad programmet heter och att man befinner sig i huvudmenyn.
             * 
             * Efter det hamnar man i en do-while-loop som skriver ut valen man har och ger användaren möjlighet att skriva in sitt val.
             * 
             * Beroende på användarens val så körs olika klasser via en switch, eller får ett felmeddelande om man skriver in något som inte finns som val.
             * 
             */
            Console.Clear();
            Console.WriteLine(".: Ö V N I N G 2 :.");
            Console.WriteLine("\n  Hej och välkommen till programmet Övning2 och dess fantastiska huvudmeny.");

            do
            {
                Console.WriteLine("\nVälj någon av funktionerna nedan:");
                Console.WriteLine("\b  0. Avsluta programmet");
                Console.WriteLine("  1. Ungdom eller pensionär");
                Console.WriteLine("  2. Upprepa 10 gånger");
                Console.WriteLine("  3. Det tredje ordet");
                Console.Write("\nDitt val: ");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        YouthOrRetired youngOrOld = new YouthOrRetired();
                        break;

                    case "2":
                        RepeatTenTimes repeat = new RepeatTenTimes();
                        break;

                    case "3":
                        TheThirdWord thirdWord = new TheThirdWord();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n- Du måste välja något av valen i menyn. -");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

            } while (true);

        }
    }
}