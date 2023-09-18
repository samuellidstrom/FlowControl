namespace FlowControl_Test01
{
    internal class MovieOneTicket
    {

        /*
         * Om användaren ska gå själv på bio räknas priset på biljetten ut här baserat på användarens ålder.
         * 
         * Jag förstår att det hade varit bättre att lägga uträkningen av biljettpris i en helt egen klass
         * för att på så sätt kunna använda samma klass för att räkna ut pris oavsett hur många som ska gå på bio.
         * 
         * Men det är lätt att vara efterklok och man lär så länge man lever.
         * 
         */
        public MovieOneTicket(int age)
        {
            int pris;
            string priskategori;

            if (age < 5 ) { pris = 0; priskategori = "GRATTS, du går in gratis! Bäbispris"; }
            else if (age < 20 & age >= 5) { pris = 80; priskategori = "Undomspris"; }
            else if (age > 64 & age <= 100) { pris = 90; priskategori = "Pensionärspris"; }
            else if (age > 100) { pris = 0; priskategori = "GRATTIS, du går in gratis! Oj, så gammal-pris"; }
            else { pris = 120; priskategori = "Standardpris"; }

            Console.WriteLine($"\n  Som {age}-åring gäller följande. | {priskategori}: {pris}kr.");

            Console.WriteLine($"\n  Tryck enter för att återgå till biograf BioLogiks huvudmeny.");
            Console.ReadLine();
            YouthOrRetired youthOrRetired = new YouthOrRetired();
        }

    }
}