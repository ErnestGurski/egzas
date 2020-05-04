namespace Ernest
{
    class Kate : Zinduoliai
    {
        public string gyvunas { get; set; }

        private enum gyvunass
        {
            Panda,
            kate,
            suo,
            asilas
        }

        public Kate(int svoris, int ugis, string pav) : base(svoris, ugis, pav)
        {
            this.gyvunas = gyvunas;
        }

        public static void GetAvailablegyvunass()
        {
            var gyvunass = Enum.GetValues(typeof(gyvunass));
            Console.WriteLine("Turimi  gyvunai:");
            foreach (var gyvunas in gyvunass)
            {
                Console.Write(gyvunas.ToString() + " ");
            }
        }

        public override string Getgyvunas()
        {
            return this.gyvunas;
        }

        ~Kate()
        {
            Console.WriteLine("Išvalyti");
        }

    }
}
