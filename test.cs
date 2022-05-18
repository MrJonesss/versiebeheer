using System;

namespace Kauwgom2
{
    class Program
    {
        static void Main(string[] args)
        {
            KauwgomAutomaat kauwgomAutomaat1 = new KauwgomAutomaat("rood");
            KauwgomAutomaat kauwgomAutomaat2 = new KauwgomAutomaat("rood", 50);

            PrintKauwgoms(kauwgomAutomaat1, kauwgomAutomaat2);

            kauwgomAutomaat1.Vergrendeld = false;

            kauwgomAutomaat1.VulBij(20);

            kauwgomAutomaat1.Vergrendeld = true;

            PrintKauwgoms(kauwgomAutomaat1, kauwgomAutomaat2);

            kauwgomAutomaat1.VulBij(75);

            PrintKauwgoms(kauwgomAutomaat1, kauwgomAutomaat2);
        }

        private static void PrintKauwgoms(KauwgomAutomaat kauwgom1, KauwgomAutomaat kauwgom2)
        {
            PrintKauwgom(kauwgom1);
            PrintKauwgom(kauwgom2);
        }

        private static void PrintKauwgom(KauwgomAutomaat kauwgomAutomaat)
        {
            Console.WriteLine(kauwgomAutomaat.Kleur + " " + kauwgomAutomaat.Aantal);
        }
    }
}
