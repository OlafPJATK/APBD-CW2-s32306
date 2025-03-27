namespace Cw2_APBD_s32306;

public abstract class Kontener
{
    private double masaLadunkuWKg;
    private double wysokoscWCm;
    private double wagaWlasnaWKg;
    private double glebokoscWCm;
    //wtf
    private string numerKontenera;
    
    private double maxLadownoscWKg;


    
    public abstract void OproznijLadunek();

    public void ZaladujKontener(double masaLadunku)
    {
        if (masaLadunku>this.maxLadownoscWKg)
        {
            throw new OverfillException();
        }
    }

}