namespace Cw2_APBD_s32306;

public class NumerSeryjny
{
    public static int currmaxId=0;
    
    private string kontener= "KON";
    private Rodzaj rodzaj;
    private int id;


    public NumerSeryjny(Rodzaj rodzaj)
    {
        this.rodzaj = rodzaj;
        this.id = NumerSeryjny.generateId();
    }
    
    public string ToString()
    {
        return kontener + "-" + rodzaj + "-" + id;
    }

    private static int generateId()
    {
        currmaxId++;
        return currmaxId;
    }
}