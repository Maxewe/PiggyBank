using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alight.Mew.Sparschwein
{
    public class moneyBox
    {

        public decimal zweiEuro { get; set; }
        public decimal einEuro { get; set; }  
        public decimal fünfzigCent { get; set; }
        public decimal zwanzigCent { get; set; } 
        public decimal zehnCent { get; set; }
        public decimal fünfCent { get; set; }
        public decimal zweiCent { get; set; }
        public decimal einCent { get; set; }   

        public moneyBox(decimal zweiEuro, decimal einEuro, decimal fünfzigCent, decimal zwanzigCent, decimal zehnCent, decimal fünfCent, decimal zweiCent, decimal einCent)
        {
            this.zweiEuro = 2;
            this.einEuro = 1;
            this.fünfzigCent = 050;
            this.zwanzigCent = 020;
            this.zehnCent = 010;
            this.fünfCent = 005;
            this.zweiCent = 002;
            this.einCent = 001;
        }

        
    }
}
