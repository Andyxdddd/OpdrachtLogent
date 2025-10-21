namespace Domein;

public abstract class Volwassene : Persoon
{
    private readonly List<Kind> _kinderen = [];
    
    public Volwassene(string naam, DateTime geboortedatum, string? foto) : base(naam, geboortedatum, foto)
    {
    }
    
    public void VoegKindToe(Kind kind)
    {
        _kinderen.Add(kind);
    }
    
    public void VerwijderKind(Kind kind)
    {
        _kinderen.Remove(kind);
    }

    public List<Kind> GeefKinderen()
    {
        return _kinderen;
    }
    
    // TODO: get kind by name
}