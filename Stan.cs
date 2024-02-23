
 public enum Lokacija
{
    Gradsko,
    Prigradsko,
}

public class Stan
{
    public int BrojKvadrata { get; set; }
    public Lokacija Lokacija { get; set; }
    public bool Namjesten { get; set; }
    public bool Internet { get; set; }

    public Stan(int brojKvadrata, Lokacija lokacija, bool namjesten, bool internet)
    {
        BrojKvadrata = brojKvadrata;
        Lokacija = lokacija;
        Namjesten = namjesten;
        Internet = internet;
    }

    public virtual void Ispisi()
    {
        Console.Write($"{BrojKvadrata,-8} {Lokacija,-11} {Namjesten,-9} {Internet,-8}");
    }

    public virtual double ObracunajCijenuNajma()
    {
        double cijena = (Lokacija == Lokacija.Gradsko) ? 200 : 150;
        cijena += BrojKvadrata;

        if (Namjesten && Internet)
        {
            cijena += cijena * 0.01;
        }
        else if (!Namjesten && Internet)
        {
            cijena += cijena * 0.02;
        }

        return cijena;
    }
}
