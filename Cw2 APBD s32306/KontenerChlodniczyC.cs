namespace Cw2_APBD_s32306;

public class KontenerChlodniczyC : Kontener, IHazardNotifier
{

    public string rodzajProduktu { get; private set; }

    public double temperaturaWKontenerze { get; private set; }

    
    public KontenerChlodniczyC(double wysokoscWCm, double wagaWlasnaWKg, double glebokoscWCm, double maxLadownoscWKg)
        : base(wysokoscWCm, wagaWlasnaWKg, glebokoscWCm, maxLadownoscWKg)
    {
        rodzaj = Rodzaj.C;
        numerKontenera = new NumerSeryjny(rodzaj);
    }

    public void NotifyHazard()
    {
        Console.WriteLine("Temperatura za wysoka w kontenerze " + numerKontenera.ToString());
    }

    public override void ZaladujKontener(double masaLadunku, string nazwaLadunkuIn)
    {
        Dictionary<string, double> productTemperatures = new Dictionary<string, double>()
        {
            { "Bananas", 13.3 },
            { "Chocolate", 18 },
            { "Fish", 2 },
            { "Meat", -15 },
            { "Ice cream", -18 },
            { "Frozen pizza", -30 },
            { "Cheese", 7.2 },
            { "Sausages", 5 },
            { "Butter", 20.5 },
            { "Eggs", 19 }
        };

        if (temperaturaWKontenerze< productTemperatures.GetValueOrDefault(nazwaLadunkuIn, 10000))
        {
            base.ZaladujKontener(masaLadunku, nazwaLadunkuIn);
        }
        else
        {
            NotifyHazard();
        }
        
    }
    
    
    
    
}