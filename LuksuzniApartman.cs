public class LuksuzniApartman : Stan
{
    private List<Osoblje> osoblje = new List<Osoblje>();

    public LuksuzniApartman(int brojKvadrata, Lokacija lokacija, bool internet) 
    : base (brojKvadrata, lokacija, true, internet) { }

    public void DodajOsoblje(Osoblje osoba)
    {
        osoblje.Add(osoba);
    }

    public override double ObracunajCijenuNajma()
    {
        double cijena = 1500;

        foreach(Osoblje osoba in osoblje)
        {
            cijena += osoba.Plata;
        }

        return cijena;
    }

}
