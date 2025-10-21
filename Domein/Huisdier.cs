namespace Domein;

public abstract class Huisdier
{
    public string Naam { get; set; }
    public DateTime Geboortedatum { get; set; }
    public bool Gevaccineerd  { get; set; }
    public Persoon Eigenaar { get; set; }
    
    public Huisdier(string naam, DateTime geboortedatum, bool gevaccineerd, Persoon eigenaar)
    {
        Naam = naam;
        Geboortedatum = geboortedatum;
        Gevaccineerd = gevaccineerd;
        Eigenaar = eigenaar;
    }
}