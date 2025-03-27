namespace Cw2_APBD_s32306;

public class KontenerNaGazG : Kontener, IHazardNotifier
{
    public KontenerNaGazG(double wysokoscWCm, double wagaWlasnaWKg, double glebokoscWCm, double maxLadownoscWKg)
        : base(wysokoscWCm, wagaWlasnaWKg, glebokoscWCm, maxLadownoscWKg)
    {
        rodzaj = Rodzaj.G;
        numerKontenera = new NumerSeryjny(rodzaj);
    }

    public void NotifyHazard()
    {
        Console.WriteLine("Niebezpieczna sytuacja w kontenerze: " + numerKontenera.ToString());
    }


    public override void OproznijLadunek()
    {
        this.nazwaLadunku = "Pusty";
        this.masaLadunkuWKg = masaLadunkuWKg * 0.05;
    }
}