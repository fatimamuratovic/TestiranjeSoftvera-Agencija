public class NenamjestenStan : Stan
{
    public NenamjestenStan(int brojKvadrata, Lokacija lokacija, bool internet)
        : base(brojKvadrata, lokacija, false, internet)
    {
    }

    public override void Ispisi()
    {
        base.Ispisi();
        Console.WriteLine();
    }

    public override double ObracunajCijenuNajma()
    {
        return base.ObracunajCijenuNajma();
    }

}