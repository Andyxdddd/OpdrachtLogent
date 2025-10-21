using Domein.Enums;

namespace Domein;

public class Kat : Huisdier
{
    public bool HoudtVanMelk { get; set; }
    public Kattenras Ras { get; init; }

    public Kat(string naam, DateTime geboortedatum, bool gevaccineerd, Persoon eigenaar, bool houdtVanMelk,
        Kattenras ras) : base(naam, geboortedatum, gevaccineerd, eigenaar)
    {
        HoudtVanMelk = houdtVanMelk;
        Ras = ras;
    }
}