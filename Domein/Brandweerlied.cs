using Domein.Interfaces;

namespace Domein;

public class Brandweerlied : Volwassene, IHulpverlener, IBeschermer
{
    public Brandweerlied(string naam, DateTime geboortedatum, string? foto) : base(naam, geboortedatum, foto)
    {
    }
    
    public void Help()
    {
        throw new NotImplementedException();
    }

    public void Bescherm()
    {
        throw new NotImplementedException();
    }
}