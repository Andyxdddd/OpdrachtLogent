namespace Domein;

public class Kind : Persoon
{
    private readonly List<Volwassene> _ouders;

    public List<Volwassene> Ouders
    {
        get => _ouders;
        private init
        {
            if (value.Count < 1) throw new ArgumentException("Kind moet minstens 1 ouder hebben");
            _ouders = value;
        }
    }

    public Kind(string naam, DateTime geboortedatum, string? foto, List<Volwassene> ouders)
        : base(naam, geboortedatum, foto)
    {
        Ouders = ouders;
    }
    
    // TODO: favorietSpeelgoed
}