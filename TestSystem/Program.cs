using Domein;
using Domein.Enums;

namespace TestSystem;

class Program
{
    static void Main(string[] args)
    {
        List<Woning> _woningen = [];
        
        var woning1 = new Woning("test", 1, 0000, "test");
        var woning2 = new Woning("test2", 2, 0000, "test");

        var volwassene1 = new Verpleger("Bob", DateTime.Now, null);
        var volwassene2 = new Politieagent("Alice", DateTime.Now, null);
        var kind1 = new Kind("Tom", DateTime.Now, null, [volwassene1, volwassene2]);

        volwassene1.VoegKindToe(kind1);
        volwassene2.VoegKindToe(kind1);

        woning1.Bewoners.Add(volwassene1);
        woning1.Bewoners.Add(volwassene2);
        woning1.Bewoners.Add(kind1);
        
        _woningen.Add(woning1);
        
        var volwassene3 = new Slager("Steve", DateTime.Now, null);
        var volwassene4 = new Brandweerlied("Alex", DateTime.Now, null);
        var kat1 = new Kat("Larry", DateTime.Now, true, volwassene3, true, Kattenras.EuropeesKorthaar);

        volwassene3.Huisdieren.Add(kat1);
        
        woning2.Bewoners.Add(volwassene3);
        woning2.Bewoners.Add(volwassene4);
        woning2.Huisdieren.Add(kat1);
        
        _woningen.Add(woning2);
        
        // -----------------------------------------

        foreach (var woning in _woningen)
        {
            foreach (var persoon in woning.Bewoners)
            {
                Console.WriteLine(persoon.Naam);
            }
            foreach (var huisdier in woning.Huisdieren)
            {
                Console.WriteLine(huisdier.Naam);
            }
        }
    }
}