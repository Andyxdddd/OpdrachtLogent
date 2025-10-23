namespace Domein;

public static class FamilyManager
{
    public static Kind MaakKind(string naam, DateTime geboortedatum, string? foto,
        List<Volwassene> ouders, string favorietSpeelgoed)
    {
        var kind = new Kind(naam, geboortedatum, foto, ouders, favorietSpeelgoed);

        foreach (var ouder in ouders) ouder.Kinderen.Add(kind);
        
        return kind;
    }

    public static void VerwijderKind(this Kind kind)
    {
        throw new NotImplementedException();
    }
}