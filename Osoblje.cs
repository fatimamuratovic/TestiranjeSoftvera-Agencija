public class Osoblje
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumUposlenja { get; set; }
    public double Plata { get; set; }
}

class Kuhar : Osoblje
{
    public List<string> Jela { get; set; }
}

class Vrtlar : Osoblje
{
    public NenamjestenStan Stan { get; set; }
}

class Batler : Osoblje
{
    public int GodineIskustva { get; set; }
}
