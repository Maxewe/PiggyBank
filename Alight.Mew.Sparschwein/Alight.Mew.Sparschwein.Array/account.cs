using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alight.Mew.Sparschwein.Test2
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public double ZweiEuro { get; set; }
        public double EinEuro { get; set; }
        public double FünfzigCent { get; set; }
        public double ZwanzigCent { get; set; }
        public double ZehnCent { get; set; } 
        public double FünfCent { get; set; }
        public double ZweiCent { get; set; }
        public double EinCent { get; set; }

        public void GetDeposit(double einCent, double zweiCent, double fünfCent, double zehnCent, double zwanzigCent, double fünfzigCent, double einEuro, double zweiEuro)
        {
            Balance += einCent + zweiCent + fünfCent + zehnCent + zwanzigCent + fünfzigCent + einEuro + zweiEuro;
        }

        public void GetWithdraw(double einCent, double zweiCent, double fünfCent, double zehnCent, double zwanzigCent, double fünfzigCent, double einEuro, double zweiEuro)
        {
            Balance -= einCent + zweiCent + fünfCent + zehnCent + zwanzigCent + fünfzigCent + einEuro + zweiEuro;
        }
    }
}
