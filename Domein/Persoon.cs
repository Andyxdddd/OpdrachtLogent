namespace Domein;

public abstract class Persoon
{
    public string Naam { get; set; }
    public DateTime Geboortedatum { get; set; }
    public string? Foto { get; set; }
    public List<Huisdier> Huisdieren { get; set; } = [];
    
    public Persoon(string naam, DateTime geboortedatum, string? foto)
    {
        Naam = naam;
        Geboortedatum = geboortedatum;
        Foto = foto;
    }
}