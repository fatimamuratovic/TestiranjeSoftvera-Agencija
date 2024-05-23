public class Osoblje
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumUposlenja { get; set; }
    public double Plata { get; set; }

    public Osoblje (string ime, string prezime, DateTime datumUposlenja, double plata)
    {
        Ime = ime;
        Prezime = prezime;
        DatumUposlenja = datumUposlenja;    
        Plata = plata;
    }
}

public class Kuhar : Osoblje
{
    public List<string> Jela { get; set; }

    public Kuhar(string ime, string prezime, DateTime datumUposlenja, double plata, List<string> jela)
    : base(ime, prezime, datumUposlenja, plata)
    {
        Jela = jela;
    }
}

public class Vrtlar : Osoblje
{
    public NenamjestenStan Stan { get; set; }

    public Vrtlar(string ime, string prezime, DateTime datumUposlenja, double plata, NenamjestenStan stan)
    : base(ime, prezime, datumUposlenja, plata)
    {
        Stan = stan;
    }
    
}

public class Batler : Osoblje
{
    public int GodineIskustva { get; set; }

    public Batler(string ime, string prezime, DateTime datumUposlenja, double plata, int godineIskustva)
    : base(ime, prezime, datumUposlenja, plata)
    {
        GodineIskustva = godineIskustva;
    }
}
