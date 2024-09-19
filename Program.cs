using CalculodeImposto.Entities;
using System;
using System.Globalization;
using System.Numerics;
namespace CalculodeImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();
            PessoaFisica pessoaFisica = new PessoaFisica();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            Taxpayer taxpayer = new Taxpayer();



            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Tax payer #{i} data: ");
                Console.WriteLine();
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                if (type == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double healthexpenditures = double.Parse(Console.ReadLine());
                    if (anualincome < 20000.00)
                    {
                        double percent = 0.15;
                        pessoaFisica.CalculoPessoaFisica(percent);
                        list.Add(new PessoaFisica(name, anualincome, healthexpenditures));
                    }
                    // list.Add(new PessoaFisica(name, anualincome, healthexpenditures));
                }
                else if (type == 'c')
                {

                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualincome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new PessoaJuridica(name, anualincome, employees));
                }
                else
                {
                    Console.WriteLine("-ERR0R-");
                    return;
                }

                Console.WriteLine();
                Console.WriteLine("TAXES PAID: ");
                foreach (Taxpayer taxapayer in list)
                {
                    Console.WriteLine($"{taxpayer.Name} : $ {taxpayer.TaxesPaid().ToString(CultureInfo.InvariantCulture)}");
                }



            }
        }
    }
}