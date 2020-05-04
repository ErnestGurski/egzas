using System;

namespace Ernest
{
    class Zinduoliai
    {
        public int uvoris { get; set; }
        public int ugis { get; set; }
        public string pav { get; set; }

        public Zinduoliai(int svoris, int ugis, string pav)
        {
            this.svoris = svoris;
            this.ugis = ugis;
            this.pav = pav;
        }

        public void PrintZinduoliaiBase()
        {
            Console.WriteLine("{0}zinduoliai {2}", this.pav, this.ugis, this.svoris);
        }

        public virtual string Getgyvunas()
        {
            return "Nėra gyvunas";
        }

        ~Zinduoliai()
        {
            Console.WriteLine("išvalyti");
        }
    }
}
