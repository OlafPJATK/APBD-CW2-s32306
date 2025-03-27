namespace Cw2_APBD_s32306;

public abstract class Kontener
{
    public double masaLadunkuWKg { get; protected set; }
    public double wysokoscWCm { get;protected set; }
    public double wagaWlasnaWKg { get; protected set; }
    public double glebokoscWCm { get;protected  set; }
    
    public NumerSeryjny numerKontenera  { get; protected set; }
    public double maxLadownoscWKg { get; protected set; }
    public Rodzaj rodzaj  { get; protected  set; }

    public string nazwaLadunku { get; protected set;}
    
    
    
    public Kontener(double wysokoscWCm, double wagaWlasnaWKg, double glebokoscWCm, double maxLadownoscWKg)
    {
        this.wysokoscWCm = wysokoscWCm;
        this.wagaWlasnaWKg = wagaWlasnaWKg;
        this.glebokoscWCm = glebokoscWCm;
        this.maxLadownoscWKg = maxLadownoscWKg;
        this.nazwaLadunku = "Brak ładunku";
    }


    public virtual void OproznijLadunek()
    {
        masaLadunkuWKg = 0;
        nazwaLadunku = "Pusty Kontener";
    }

    public virtual void ZaladujKontener(double masaLadunku, string nazwaLadunkuIn)
    {
        if (masaLadunku>maxLadownoscWKg)
        {
            throw new OverfillException();
        }
    }


    public NumerSeryjny GetnumerKontenera()
    {
        return numerKontenera;
    }
}