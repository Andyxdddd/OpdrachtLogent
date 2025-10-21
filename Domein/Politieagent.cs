using Domein.Interfaces;

namespace Domein;

public class Politieagent : Volwassene, IBeschermer
{
    public Politieagent(string naam, DateTime geboortedatum, string? foto) : base(naam, geboortedatum, foto)
    {
    }

    public void Bescherm()
    {
        throw new NotImplementedException();
    }
}