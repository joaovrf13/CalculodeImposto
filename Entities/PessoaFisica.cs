using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeImposto.Entities
{
    internal class PessoaFisica : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string name, double anualIncome, double healthExpenditures)
        {
            Name = name;
            AnualIncome = anualIncome;
            HealthExpenditures = healthExpenditures;
        }

       public double CalculoPessoaFisica(double percent)
        {
            return (AnualIncome * percent); 
        }

       public double CalculateHealthExpenditures(double percent)
        {
            return (AnualIncome * percent) - (HealthExpenditures * 0.5);
        }

        public override string TaxesPaid()
        {
            return $": $ {CalculoPessoaFisica}";
        }

        
    }
}
