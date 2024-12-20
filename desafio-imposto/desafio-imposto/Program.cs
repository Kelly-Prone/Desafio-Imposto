using System;
using System.Globalization;

namespace DesafioImposto
{
    class Program
    {
        static void Main(string[] args)
        {

            // Define a cultura padrão para utilizar "." como separador decimal
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Renda anual com salário: ");
            double salarioAnual = double.Parse(Console.ReadLine());

            Console.Write("Renda anual com prestação de serviço: ");
            double prestacaoServicoAnual = double.Parse(Console.ReadLine());

            Console.Write("Renda anual com ganho de capital: ");
            double capitalAnual = double.Parse(Console.ReadLine());

            Console.Write("Gastos médicos: ");
            double gastosMedicos = double.Parse(Console.ReadLine());

            Console.Write("Gastos educacionais: ");
            double gastosEducacionais = double.Parse(Console.ReadLine());

            double salarioMensal = salarioAnual / 12;
            double impostoSalario = 0;

            if (salarioMensal >= 3000 && salarioMensal < 5000)
            {
                impostoSalario = salarioAnual * 0.10;
            }
            else if (salarioMensal >= 5000)
            {
                impostoSalario = salarioAnual * 0.20;
            }

            double impostoServico = prestacaoServicoAnual * 0.15;
            double impostoGanhoCapital = capitalAnual * 0.20;
            double impostoBruto = impostoSalario + impostoServico + impostoGanhoCapital;
            double descontoImposto = impostoBruto * 0.30;
            double descontoEfetivo = Math.Min(gastosEducacionais, descontoImposto);
            double impostoLiquido = impostoBruto - descontoEfetivo;

            Console.WriteLine("\n ----- RELATÓRIO DE IMPOSTO DE RENDA ----");
            Console.WriteLine("\n CONSOLIDADO DE RENDA:");
            Console.WriteLine($"Imposto sobre salário: R$ {impostoSalario:F2}");
            Console.WriteLine($"Imposto sobre prestação de serviços: R$ {impostoServico:F2}");
            Console.WriteLine($"Imposto sobre ganho de capital: R$ {impostoGanhoCapital:F2}");

            Console.WriteLine("\n DEDUÇÕES:");
            Console.WriteLine($"Máximo dedutível: R$ {descontoImposto:F2}");

            Console.WriteLine("\n RESUMO:");
            Console.WriteLine($"Imposto bruto total: R$ {impostoBruto:F2}");
            Console.WriteLine($"Abatimento: R$ {descontoEfetivo:F2}");
            Console.WriteLine($"Imposto devido: R$ {impostoLiquido:F2}");

        }
    }
}