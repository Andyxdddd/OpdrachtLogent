namespace Domein;

public abstract class Volwassene : Persoon
{
    public List<Kind> Kinderen { get; } = [];
    
    public Volwassene(string naam, DateTime geboortedatum, string? foto) : base(naam, geboortedatum, foto)
    {
    }
}