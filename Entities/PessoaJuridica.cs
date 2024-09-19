using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculodeImposto.Entities
{
    internal class PessoaJuridica : Taxpayer
    {
        public int Employees { get; set; }

        public PessoaJuridica() 
        { 
        }

        public PessoaJuridica(string name, double anualIncome, int employees)
        {
            Name = name;
            AnualIncome = anualIncome;
            Employees = employees;
        }
        
        public double CalculoPessoaJuridica(double percent)
        {
            return (AnualIncome * percent);

        }

        public override string TaxesPaid()
        {
            return $": $ ";
        }
    }
}
