using Domein.Interfaces;

namespace Domein;

public class Verpleger : Volwassene, IHulpverlener
{
    public Verpleger(string naam, DateTime geboortedatum, string? foto) : base(naam, geboortedatum, foto)
    {
    }
    
    public void Help()
    {
        throw new NotImplementedException();
    }
}