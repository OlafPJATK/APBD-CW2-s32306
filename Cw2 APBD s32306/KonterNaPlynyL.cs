namespace Cw2_APBD_s32306;

public class KonterNaPlynyL : Kontener, IHazardNotifier
{
    private Boolean isSafe;

    public KonterNaPlynyL(double wysokoscWCm, double wagaWlasnaWKg, double glebokoscWCm, double maxLadownoscWKg) : base(wysokoscWCm, wagaWlasnaWKg, glebokoscWCm, maxLadownoscWKg)
    {
        rodzaj = Rodzaj.L;
        numerKontenera = new NumerSeryjny(rodzaj);
    }
    
    public void NotifyHazard()
    {
        Console.WriteLine("Niebezpieczna sytuacja w kontenerze: " + numerKontenera.ToString());
    }

    public override void ZaladujKontener(double masaLadunku, string nazwaLadunkuIn)
    {
        //tu sprawdzenie listy niebezpiecznych ladunkwo w rozszerzonej wersji
        if (nazwaLadunkuIn.ToLower().Equals("Paliwo".ToLower()))
        {
            isSafe = false;
        }
        else
        {
            isSafe = true;
        }
        
        if (masaLadunku>maxLadownoscWKg)
        {
            throw new OverfillException();
        }
        
        if (!isSafe)
        {
            if (masaLadunku>maxLadownoscWKg/2)
            {
                NotifyHazard();
            }
            else
            {
                masaLadunkuWKg = masaLadunku;
            }
        }
        else
        {
            if (masaLadunku>maxLadownoscWKg*9/10)
            {
                NotifyHazard();
            }
            else
            {
                masaLadunkuWKg = masaLadunku;
            }
        }
    }
}