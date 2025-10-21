namespace Domein;

public abstract class Huisdier
{
    public string Naam { get; set; }
    public DateTime Geboortedatum { get; set; }
    public Boolean Gevaccineerd  { get; set; }
    
    public Huisdier(string naam, DateTime geboortedatum, bool gevaccineerd)
    {
        Naam = naam;
        Geboortedatum = geboortedatum;
        Gevaccineerd = gevaccineerd;
    }
}