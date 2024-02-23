public class NamjestenStan : Stan
{
    public double VrijednostNamjestaja { get; set; }
    public int BrojAparata { get; set; }

    public NamjestenStan(int brojKvadrata, Lokacija lokacija, bool internet, double vrijednostNamjestaja, int brojAparata)
        : base(brojKvadrata, lokacija, true, internet)
    {
        VrijednostNamjestaja = vrijednostNamjestaja;
        BrojAparata = brojAparata;
    }

    public override void Ispisi()
    {
        base.Ispisi();
        Console.Write($" {VrijednostNamjestaja,-21} {BrojAparata,-10}");
        Console.WriteLine();
    }

    public override double ObracunajCijenuNajma()
    {
        double cijena = base.ObracunajCijenuNajma();

        if (BrojAparata < 3)
        {
            cijena += VrijednostNamjestaja * 0.01;
        }
        else
        {
            cijena += VrijednostNamjestaja * 0.02;
        }

        return cijena;
    }
}
