
public class Agencija
{
    public List<Stan> Stanovi {get; private set;}
    public List<Osoblje> Osoblje {get; private set;}


    public Agencija()
    {
        Stanovi = new List<Stan>();
        Osoblje = new List<Osoblje>(); 
    }
    public void DodajStan(Stan stan)
    {
        Stanovi.Add(stan);
    }

    public void DodajOsoblje(Osoblje osoba)
    {
        if(Osoblje.Contains(osoba))
        {
            throw new InvalidOperationException("Osoba je već dodana u listu zaposlenika! ");
        }
        
        Osoblje.Add(osoba);
    }
    public void IspisiSveStanove()
    {
        Console.WriteLine("Površina Lokacija   Namješten Internet Vrijednost namještaja Broj aparata");
        foreach (var stan in Stanovi.OrderBy(s => s.ObracunajCijenuNajma()))
        {
            stan.Ispisi();
            Console.WriteLine($" {stan.ObracunajCijenuNajma():F2}");
        }
    }


    public void IspisiSveOsoblje()
    {
        Console.WriteLine("Ime       Prezime    Datum uposlenja  Plata");
        foreach (Osoblje osoba in Osoblje.OrderBy(o => o.Plata))
        {
            Console.WriteLine($"{osoba.Ime,-10} {osoba.Prezime,-10} {osoba.DatumUposlenja.ToShortDateString(),-15} {osoba.Plata:F2}");
        }
    }
}
