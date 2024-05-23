using System;
using System.IO;
using Xunit;

namespace AgencijaStanova.Tests
{
    public class AgencijaTests
    {
        [Fact]
        public void DodajOsoblje_DodavanjeOsoblja_OsobljeDodano()
        {
            var agencija = new Agencija();
            var osoba = new Osoblje ("Selma", "Selimović", DateTime.Now, 1000);

            int initialCount = agencija.Osoblje.Count;
            agencija.DodajOsoblje(osoba);

            Assert.Equal(initialCount+1, agencija.Osoblje.Count);
        }
        
    }
}