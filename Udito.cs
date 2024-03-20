namespace gyumolcsbolt
{
    class Udito: Aru
    {
        public double GyumolcsTartalom { get; set; }
        public Udito(string nev, int ar, double mennyiseg, Mertekegysegek mertekegyseg, double gyumolcsTartalom) : base(nev, ar, mennyiseg, mertekegyseg)
        {
            GyumolcsTartalom = gyumolcsTartalom;
        }

        public override string ToString()
        {
            return base.ToString() + $" - {GyumolcsTartalom} % gyümölcstartalom";
        }
    }
}
