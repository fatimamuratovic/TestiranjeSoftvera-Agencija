
public class Agencija
{
    private List<Stan> stanovi = new List<Stan>();
    private List<Osoblje> osoblje = new List<Osoblje>();

    public void DodajStan(Stan stan)
    {
        stanovi.Add(stan);
    }

    public void IspisiSveStanove()
    {
        Console.WriteLine("Površina Lokacija   Namješten Internet Vrijednost namještaja Broj aparata");
        foreach (Stan stan in stanovi.OrderBy(s => s.ObracunajCijenuNajma()))
        {
            stan.Ispisi();
            Console.WriteLine($" {stan.ObracunajCijenuNajma():F2}");
        }
    }

    public void DodajOsoblje(Osoblje osoba)
    {
        osoblje.Add(osoba);
    }

    public void IspisiSveOsoblje()
    {
        Console.WriteLine("Ime       Prezime    Datum uposlenja  Plata");
        foreach (Osoblje osoba in osoblje.OrderBy(o => o.Plata))
        {
            Console.WriteLine($"{osoba.Ime,-10} {osoba.Prezime,-10} {osoba.DatumUposlenja.ToShortDateString(),-15} {osoba.Plata:F2}");
        }
    }
}
