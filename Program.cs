using System;

class Program
{
    static void Main(string[] args)
    {

        Agencija agencija = new Agencija();
        Stan[] stanovi = new Stan[5];
        stanovi[0] = new NenamjestenStan(50, Lokacija.Gradsko, true);
        stanovi[1] = new NenamjestenStan(80, Lokacija.Prigradsko, true);
        stanovi[2] = new NamjestenStan(40, Lokacija.Prigradsko, true, 2000, 2);
        stanovi[3] = new NamjestenStan(80, Lokacija.Gradsko, false, 3000, 6);
        stanovi[4] = new LuksuzniApartman(80, Lokacija.Gradsko, false);
        foreach (Stan stan in stanovi) { agencija.DodajStan(stan); }
        agencija.IspisiSveOsoblje();
        agencija.IspisiSveStanove();
        
    }

}