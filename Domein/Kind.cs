namespace Domein;

public class Kind : Persoon
{
    public string FavorietSpeelgoed { get; set; }

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

    public Kind(string naam, DateTime geboortedatum, string? foto, List<Volwassene> ouders, string favorietSpeelgoed)
        : base(naam, geboortedatum, foto)
    {
        Ouders = ouders;
        FavorietSpeelgoed = favorietSpeelgoed;
    }
}