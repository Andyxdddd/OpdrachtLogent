using Domein.Enums;

namespace Domein;

public class Kat: Huisdier
{
    public bool HoudtVanMelk { get; set; }
    public Kattenras Ras { get; init; }
    
    public Kat(string naam, DateTime geboortedatum, bool gevaccineerd, bool houdtVanMelk, Kattenras ras) : base(naam, geboortedatum, gevaccineerd)
    {
        HoudtVanMelk = houdtVanMelk;
        Ras = ras;
    }
}