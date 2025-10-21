using Domein.Interfaces;

namespace Domein;

public class Slager : Volwassene
{
    public Slager(string naam, DateTime geboortedatum, string? foto) : base(naam, geboortedatum, foto)
    {
    }
}