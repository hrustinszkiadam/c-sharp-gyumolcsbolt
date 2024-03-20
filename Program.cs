namespace gyumolcsbolt
{
    class Program
    {
        static void Main(string[] args)
        {
            Aru[] aruk = new Aru[10] {
                new Gyumolcs("Alma", 100, 1, Mertekegysegek.kg),
                new Gyumolcs("Körte", 200, 1, Mertekegysegek.kg),
                new Gyumolcs("Banán", 300, 1, Mertekegysegek.kg),
                null,
                new Udito("Narancslé", 800, 1.5, Mertekegysegek.l, 40),
                new Udito("Almalé", 900, 1.5, Mertekegysegek.l, 50),
                null,
                new Gyumolcs("Ananász", 1000, 1, Mertekegysegek.kg),
                new Gyumolcs("Mango", 1200, 1, Mertekegysegek.kg),
                null,
            };

            for (int i = 0; i < aruk.Length; i++)
            {
                if(aruk[i] is null) aruk[i] = getAru();
            }

            KiirGyumolcs(aruk);
            KiirUdito(aruk);    
            KiirUditoGyumolcsTartalom(aruk);

            Console.ReadKey();
        }

        static void KiirGyumolcs(Aru[] aruk)
        {
            Console.WriteLine("\nGyümölcsök:");
            foreach (var item in aruk)
            {
                if (item is Gyumolcs gyumi)
                {
                    Console.WriteLine(gyumi);
                }
            }
        }

        static void KiirUdito(Aru[] aruk)
        {
            Console.WriteLine("\nÜdítők:");
            foreach (var item in aruk)
            {
                if (item is Udito udito)
                {
                    Console.WriteLine(udito);
                }
            }
        }
        
        static void KiirUditoGyumolcsTartalom(Aru[] aruk)
        {
            Console.WriteLine("\nÜdítők gyümölcstartalma:");
            foreach (var item in aruk)
            {
                if (item is Udito udito)
                {
                    Console.WriteLine($"{udito.Nev} - {udito.Mennyiseg * udito.GyumolcsTartalom / 100}/{udito.Mennyiseg} {udito.Mertekegyseg}");
                }
            }
        }

        static Aru? getAru()
        {
            Console.WriteLine("Milyen áru?");
            Console.WriteLine("1. Gyümölcs");
            Console.WriteLine("2. Üdítő");
            int valasztas;
            while (!int.TryParse(Console.ReadLine(), out valasztas) || valasztas < 1 || valasztas > 2)
            {
                Console.WriteLine("Hibás választás! Próbáld újra!");
            }

            Console.Write("Név (* - kilépés): ");
            string nev = Console.ReadLine() ?? string.Empty;
            while (string.IsNullOrEmpty(nev))
            {
                Console.WriteLine("Hibás név! Próbáld újra!");
            }

            if(nev == "*")
            {
                return null;
            }

            Console.Write("Ár: ");
            int ar;
            while (!int.TryParse(Console.ReadLine(), out ar) || ar < 0)
            {
                Console.WriteLine("Hibás ár! Próbáld újra!");
            }

            Console.Write("Mennyiség: ");
            double mennyiseg;
            while (!double.TryParse(Console.ReadLine(), out mennyiseg) || mennyiseg < 0)
            {
                Console.WriteLine("Hibás mennyiség! Próbáld újra!");
            }

            Console.WriteLine("Mértékegység: ");
            int mertekegyseg;
            if(valasztas == 1)
            {
                Console.WriteLine("1. g");
                Console.WriteLine("2. kg");
                while (!int.TryParse(Console.ReadLine(), out mertekegyseg) || mertekegyseg < 1 || mertekegyseg > 2)
                {
                    Console.WriteLine("Hibás választás! Próbáld újra!");
                }
            }
            else
            {
                Console.WriteLine("1. dl");
                Console.WriteLine("2. l");
                while (!int.TryParse(Console.ReadLine(), out mertekegyseg) || mertekegyseg < 1 || mertekegyseg > 2)
                {
                    Console.WriteLine("Hibás választás! Próbáld újra!");
                }
            }

            if(valasztas == 1)
            {
                return new Gyumolcs(nev, ar, mennyiseg, (Mertekegysegek)mertekegyseg + 1);
            } else {
                Console.Write("Gyümölcstartalom (százalékban): ");
                double gyumolcsTartalom;
                while (!double.TryParse(Console.ReadLine(), out gyumolcsTartalom) || gyumolcsTartalom < 0 || gyumolcsTartalom > 100)
                {
                    Console.WriteLine("Hibás gyümölcstartalom! Próbáld újra!");
                }
                return new Udito(nev, ar, mennyiseg, (Mertekegysegek)mertekegyseg - 1, gyumolcsTartalom);
            }
        }
    }
}
