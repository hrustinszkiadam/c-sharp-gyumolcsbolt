namespace gyumolcsbolt
{
    class Gyumolcs : Aru
    {
        public bool isFriss { get; set; }
        public Gyumolcs(string nev, int ar, double mennyiseg, Mertekegysegek mertekegyseg) : base(nev, ar, mennyiseg, mertekegyseg)
        {
            this.isFriss = true;
        }

        public override string ToString()
        {
            return base.ToString() + (isFriss ? " - friss" : " - nem friss");
        }
    }
}
