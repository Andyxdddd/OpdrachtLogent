using Domein;
using Domein.Enums;

namespace TestSystem;

class Program
{
    static void Main(string[] args)
    {
        List<Woning> woningen = [];

        // -----------------------------------------
        
        var woning1 = new Woning("StraatA", 1, 0000, "StadA");
        var woning2 = new Woning("StraatA", 2, 0000, "StadA");

        var volwassene1 = new Verpleger("Bob", DateTime.Now, null);
        var volwassene2 = new Politieagent("Alice", DateTime.Now, null);
        var kind1 = FamilyManager.MaakKind("Tommy", DateTime.Now, null, [volwassene1, volwassene2], "Lufufu");

        woning1.Bewoners.AddRange(volwassene1, volwassene2, kind1);
        woningen.Add(woning1);
        
        // -----------------------------------------
        
        var volwassene3 = new Slager("Steve", DateTime.Now, null);
        var volwassene4 = new Brandweerlied("Alex", DateTime.Now, null);
        var kat1 = new Kat("Evil Larry", DateTime.Now, true, volwassene3, true, Kattenras.EuropeesKorthaar);
        volwassene3.Huisdieren.Add(kat1);
        var hond1 = new Hond("Scooby Doo", DateTime.Now, false, volwassene4, true, HondGrootte.Middel);
        volwassene4.Huisdieren.Add(hond1);

        woning2.Bewoners.AddRange(volwassene3, volwassene4);
        woning2.Huisdieren.AddRange(kat1, hond1);
        woningen.Add(woning2);

        // -----------------------------------------

        foreach (var woning in woningen)
        {
            Console.WriteLine($"Op adres ({woning.Straatnaam} {woning.Huisnummer}, {woning.Postcode} {woning.Stad}) woont:");
            foreach (var persoon in woning.Bewoners)
            {
                Console.WriteLine($"{persoon.Naam} ({persoon.GetType().Name})");
                Console.WriteLine();
            }

            foreach (var huisdier in woning.Huisdieren)
            {
                Console.WriteLine($"{huisdier.Naam} ({huisdier.GetType().Name})");
            }
            
            Console.WriteLine();
        }
    }
}