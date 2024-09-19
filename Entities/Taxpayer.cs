using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeImposto.Entities
{
    internal class Taxpayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Taxpayer()
        {
        }

        public Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public virtual string TaxesPaid()
        {
            return $"{Name} ";
        }


    }
}
