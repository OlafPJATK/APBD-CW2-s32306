using System.Collections;

namespace Cw2_APBD_s32306;

public class Kontenerowiec
{
    public ArrayList konteneryList { get; private set; }
    public double maxSpeed{ get; private set; }
    public int maxNumberOfContainers{ get; private set; }
    public double maxWagaKontenerow{ get; private set; }

    public double obecnaWagaLadunku { get; private set; }

    public Kontenerowiec(double maxSpeed, int maxNumberOfContainers, double maxWagaKontenerow)
    {
        this.maxSpeed = maxSpeed;
        this.maxWagaKontenerow = maxWagaKontenerow;
        this.maxNumberOfContainers = maxNumberOfContainers;
        this.konteneryList = new ArrayList();
    }



    public void addKontenerToStatek(Kontener kontener)
    {
        if (maxWagaKontenerow<obecnaWagaLadunku)
        {
            this.konteneryList.Add(kontener);
        }
        
    }
    
    public void addKontenerToStatek(Kontener[] kontener)
    {
        if (maxWagaKontenerow<obecnaWagaLadunku)
        {
            this.konteneryList.AddRange(kontener);
        }
        
    }

    public void popKontener()
    {
        this.konteneryList.RemoveAt(konteneryList.Count-1);
    }

    public void remove(Kontener kontener)
    {
        this.konteneryList.Remove(kontener);
    }

    public void replaceKontener(NumerSeryjny numerSeryjny, Kontener drugiKontener)
    {
        foreach (Kontener x in this.konteneryList){
            if (x.numerKontenera.ToString().Equals(numerSeryjny.ToString()))
            {
             int tmp  = this.konteneryList.IndexOf(x);
             this.konteneryList.Remove(x);
             this.konteneryList.Insert(tmp, drugiKontener);
            }
            
        }

    }

    
    public override string ToString()
    {
        return $"Nazwa statku: {this.GetType().Name}\n" +
               $"Maksymalna prędkość: {this.maxSpeed} węzłów\n" +
               $"Maksymalna liczba kontenerów: {this.maxNumberOfContainers}\n" +
               $"Maksymalna waga kontenerów: {this.maxWagaKontenerow} kg\n" +
               $"Obecna waga ładunku: {this.obecnaWagaLadunku} kg\n" +
               $"Liczba kontenerów na statku: {this.konteneryList.Count}\n" +
               $"Lista kontenerów:\n" + this.konteneryList;
    }

    public static void moveKontener(Kontenerowiec kontenerowiec1, Kontenerowiec kontenerowiec2, Kontener kontenerDoPrzeniesienia)
    {
        kontenerowiec1.remove(kontenerDoPrzeniesienia);
        kontenerowiec2.addKontenerToStatek(kontenerDoPrzeniesienia);
    }

}