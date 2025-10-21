using Domein.Enums;
using Domein.Interfaces;

namespace Domein;

public class Hond : Huisdier, IBeschermer
{
    public bool Kindvriendelijk { get; set; }
    public HondGrootte Grootte { get; init; }

    public Hond(string naam, DateTime geboortedatum, bool gevaccineerd, Persoon eigenaar, bool kindvriendelijk,
        HondGrootte grootte) : base(naam, geboortedatum, gevaccineerd, eigenaar)
    {
        Kindvriendelijk = kindvriendelijk;
        Grootte = grootte;
    }

    public void Bescherm()
    {
        throw new NotImplementedException();
    }
}