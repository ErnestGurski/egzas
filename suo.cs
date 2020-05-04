using System;

namespace Ernest
{
    class Suo : Zinduoliai
    {
        public string gyvunas { get; set; }
        public int Line { get; set; }

        private enum gyvunass
        {
            meska,
            leopardas,
            gepardas,
            zebra
        }

        public Suo(int svoris, int ugis, string pav) : base(svoris, ugis, pav)
        {
            this.gyvunas = gyvunas;
        }

        public static void GetAvailablegyvunass()
        {
            var gyvunass = Enum.GetValues(typeof(gyvunass));
            Console.WriteLine("Available gyvunass:");
            foreach (var gyvunas in gyvunass)
            {
                Console.Write(gyvunas.ToString() + " ");
            }
        }

        public override string Getgyvunas()
        {
            return this.gyvunas;
        }
       

        public void PrintAbout()
        {
            Console.WriteLine("Gyvunas:", this.Line, Getgyvunas());
            PrintZinduoliaiBase();
        }

        ~Suo()
        {
            Console.WriteLine("Išlavyti");
        }

    }
}
