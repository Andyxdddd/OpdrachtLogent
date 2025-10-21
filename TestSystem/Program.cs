using Domein;

namespace TestSystem;

class Program
{
    static void Main(string[] args)
    {
        var woning1 = new Woning("test", 1, 0000, "test");
        
        var volwassene1 = new Verpleger("Bob", DateTime.Now, null);
        var volwassene2 = new Verpleger("Alice", DateTime.Now, null);
        
        var kind1 = new Kind("Tom", DateTime.Now, null, [volwassene1, volwassene2]);
        
        volwassene1.VoegKindToe(kind1);
        volwassene2.VoegKindToe(kind1);

        volwassene2.Help();
        
        woning1.Bewoners.Add(volwassene1);
        woning1.Bewoners.Add(volwassene2);
        woning1.Bewoners.Add(kind1);

        foreach (var item in woning1.Bewoners)
        {
            Console.WriteLine(item.Naam);
        }

        foreach (var item in kind1.Ouders)
        {
            Console.WriteLine(item.Naam);
        }
    }
}