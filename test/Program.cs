using System;



namespace LoteriaLiczbowa

{

    public static class Kalkulator

    {

        public static int Losuj()
        {
            Random random = new Random();

            return random.Next(-7,7);
        }

        public static int Dodaj(int a ,int b)
        {
            return (a + b);
        }
       
            

            public static bool CzyDodatnia(int liczba)

            {

                return liczba > 0;

            }
        public static int PoleProstokata(int bokA, int bokB)

        {

            if (bokA <= 0 || bokB <= 0)

            {

                throw new ArgumentException("Boki muszą być dodatnie.");

            }

            return bokA * bokB;

        }

        

        public static bool CzyPoprawnaLiczba(int liczbaZestawow)

        {

            return liczbaZestawow >= 1 && liczbaZestawow <= 100;

        }

        public static string Opisz(int ocena)

        {

            if (ocena < 1 || ocena > 6)

            {

                return "ocena nieprawidlowa";

            }

            if (ocena <= 2)

            {

                return "ocena niska";

            }

            if (ocena <= 4)

            {

                return "ocena srednia";

            }

            return "ocena wysoka";

        }



        static void Main()

        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(Losuj());
            }
            

        }




    }

}