namespace Cw2_APBD_s32306;

public abstract class Kontener
{
    protected double masaLadunkuWKg {  get; set; }
    protected double wysokoscWCm { get; set; }
    protected double wagaWlasnaWKg { get; set; }
    protected double glebokoscWCm { get; set; }
    
    protected NumerSeryjny numerKontenera  { get; set; }
    protected double maxLadownoscWKg { get; set; }
    protected Rodzaj rodzaj  { get; set; }

    protected string nazwaLadunku { get; set;}
    
    
    public Kontener(double wysokoscWCm, double wagaWlasnaWKg, double glebokoscWCm, double maxLadownoscWKg)
    {
        this.wysokoscWCm = wysokoscWCm;
        this.wagaWlasnaWKg = wagaWlasnaWKg;
        this.glebokoscWCm = glebokoscWCm;
        this.maxLadownoscWKg = maxLadownoscWKg;
    }


    public void OproznijLadunek()
    {
        masaLadunkuWKg = 0;
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