using System;

namespace MattiasTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random slumpat = new Random();
            int speltal = slumpat.Next(1, 20);
            bool spela = true;
            int number = 0;
            while (spela)
            {
                bool succes = false;
                //int.TryParse har två parametrar den första är en sträng(Console.Readline ger en sträng och koden
                //är tillräckligt smart att veta det) och den andra är en int !!om tryparsen godkänner strängen
                //som en int!!
                //I while satsen nedan för så fortsätter den fråga dig att skriva in ett tal mellan 1 - 20 tills du ger den
                //en sträng som kan konverteras till heltal och när tryparsen ser att du skrivit ett heltal så sätter
                //den succes till true
                while (succes == false)
                {
                    Console.WriteLine("gissa mellan 1 - 20");
                    succes = int.TryParse(Console.ReadLine(), out number);
                }

                if (number < speltal)
                //i den första if satsen står det "Om number är mindre än speltal" så ska den gå in här
                {
                    Console.WriteLine("Ditt tal är för litet");
                }
                if (number > speltal)
                //i den andra if satsen står det "Om number är större än speltal" så ska den gå in här
                {
                    Console.WriteLine("Ditt tal är för stort");
                }
                if (number == speltal)
                //I den tredje if satsen så står det "Om number och speltal är samma" så ska den gå in här
                {
                    Console.WriteLine("Du vann!");
                    spela = false;
                }
            }
        }
    }
}