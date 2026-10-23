using Xunit;
namespace LoteriaLiczbowa
{
    public class UnitTest1
    {
        
        [Fact]
        public void CzyDodatnia_Liczba_ZwracaTrueFalse()
        {
            bool wynik = Kalkulator.CzyDodatnia(2);
            Assert.True(wynik);

        }

        [Fact]
        public void CzyDodatnia_Ujemna_ZwracaTrueFalse()
        {
            bool wynik = Kalkulator.CzyDodatnia(-56);
            Assert.False(wynik);

        }

        [Fact]
        public void CzyDodatnia_Zero_ZwracaTrueFalse()
        {
            bool wynik = Kalkulator.CzyDodatnia(0);
            Assert.False(wynik);

        }


        //============================================



        [Fact]
        public void PoleProstokata_()
        {
            int wynik = Kalkulator.PoleProstokata(3, 5);

            Assert.Equal(15, wynik);
        }

        [Fact]
        public void PoleProstokata_Jeden_ZwracaJeden()
        {
            int wynik = Kalkulator.PoleProstokata(1, 1);

            Assert.Equal(1, wynik);
        }

        [Fact]
        public void PoleProstokata_ArgumentZero_ZwracaBłąd()
        {

            Assert.Throws<ArgumentException>(() => Kalkulator.PoleProstokata(3, 0));
        }

        //===============================================

        [Fact]
        public void CzyPoprawnaLiczba_przedJeden_ZwracaFalse()
        {

            bool wynik = Kalkulator.CzyPoprawnaLiczba(0);
            Assert.False(wynik);
        }

        [Fact]
        public void CzyPoprawnaLiczba_Jeden_ZwracaTrue()
        {
            bool wynik = Kalkulator.CzyPoprawnaLiczba(1);
            Assert.True(wynik);
        }
        [Fact]
        public void CzyPoprawnaLiczba_poJeden_ZwracaTrue()
        {
            bool wynik = Kalkulator.CzyPoprawnaLiczba(2);
            Assert.True(wynik);
        }




        [Fact]
        public void CzyPoprawnaLiczba_przedSto_ZwracaTrue()
        {
            bool wynik = Kalkulator.CzyPoprawnaLiczba(99);
            Assert.True(wynik);
        }

        [Fact]
        public void CzyPoprawnaLiczba_Sto_ZwracaTrue()
        {
            bool wynik = Kalkulator.CzyPoprawnaLiczba(100);
            Assert.True(wynik);
        }

        [Fact]
        public void CzyPoprawnaLiczba_poSto_ZwracaFalse()
        {
            bool wynik = Kalkulator.CzyPoprawnaLiczba(101);
            Assert.False(wynik);
        }


        //============================================

        [Theory]
        [InlineData(1,"ocena niska")]
        [InlineData(2, "ocena niska")]
        [InlineData(3, "ocena srednia")]
        [InlineData(4, "ocena srednia")]
        [InlineData(5, "ocena wysoka")]
        [InlineData(6, "ocena wysoka")]
        [InlineData(7, "ocena nieprawidlowa")]
        [InlineData(0, "ocena nieprawidlowa")]
        public void Opisz_Liczba_ZwracaOcene(int liczba,string oczekiwana)
        {

            string wynik = Kalkulator.Opisz(liczba);

            Assert.Equal(oczekiwana, wynik);
        }

        

    }
}
