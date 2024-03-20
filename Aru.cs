namespace gyumolcsbolt
{
    class Aru
    {
        public string Nev { get; set; }
        public int Ar { get; set; }
        public double Mennyiseg { get; set; }
        public Mertekegysegek Mertekegyseg { get; set; }

        public Aru(string nev, int ar, double mennyiseg, Mertekegysegek mertekegyseg)
        {
            Nev = nev;
            Ar = ar;
            Mennyiseg = mennyiseg;
            Mertekegyseg = mertekegyseg;
        }

        public override string ToString()
        {
            return $"{Nev} - {Ar} Ft/{Mennyiseg} {Mertekegyseg}";
        }
    }
}
