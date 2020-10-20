using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alight.Mew.Sparschwein.Test
{
    class moneyBox
    {
        public double zweiEuro { get; set; }
        public double einEuro { get; set; }
        public double fünfzigCent { get; set; }
        public double zwanzigCent { get; set; }
        public double zehnCent { get; set; }
        public double fünfCent { get; set; }
        public double zweiCent { get; set; }
        public double einCent { get; set; }

        public moneyBox(double zweiEuro, double einEuro, double fünfzigCent, double zwanzigCent, double zehnCent, double fünfCent, double zweiCent, double einCent)
        {
            this.zweiEuro = 2.00;
            this.einEuro = 1.00;
            this.fünfzigCent = 0.50;
            this.zwanzigCent = 0.20;
            this.zehnCent = 0.10;
            this.fünfCent = 0.05;
            this.zweiCent = 0.02;
            this.einCent = 0.01;
        }
    }
}
