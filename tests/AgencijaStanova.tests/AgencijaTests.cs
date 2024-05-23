using System;
using System.IO;
using Xunit;

namespace TestiranjeSoftvera-Agencija.Tests
{
    public class AgencijaTests
    {
        public void DodajOsoblje_DodavanjeOsoblja_OsobljeDodano()
        {
            var agencija = new Agencija();
            var osoba = new Osoblje ("Selma", "Selimović", DateTime.Now, 1000);

            int initialCount = agencija.osoblje.Count;
            agencija.DodajOsoblje(osoba);

            Assert.Equal(initialCount+1, agencija.osoblje.Count);
        }
    }
}