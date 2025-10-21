namespace Domein;

public class Woning
{
    public string Straatnaam { get; set; }
    public int Huisnummer { get; set; }
    public int Postcode { get; set; }
    public string Stad { get; set; }
    public List<Persoon> Bewoners { get; } = [];
    public List<Huisdier> Huisdieren { get; } = [];
    
    public Woning(string straatnaam, int huisnummer, int postcode, string stad)
    {
        Straatnaam = straatnaam;
        Huisnummer = huisnummer;
        Postcode = postcode;
        Stad = stad;
    }
}