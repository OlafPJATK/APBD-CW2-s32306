namespace Cw2_APBD_s32306;

class Program
{
    static void Main(string[] args)
    {

        KonterNaPlynyL plynyL = new KonterNaPlynyL(20, 100, 2000, 100);
        
        plynyL.ZaladujKontener(100,"dddd");
        
        Console.WriteLine(plynyL.GetnumerKontenera().ToString());
        
        
    }
}