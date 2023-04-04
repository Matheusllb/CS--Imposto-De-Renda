using System;
using System.Globalization;

namespace CsE14
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //EXERCÍCIO 14
            Console.WriteLine("Calculo de imposto de renda\n\nINFORME SEU SÁLARIO: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double calculo8, calculo18, calculo28;
            if (salario >= 0.00 && salario <= 2000.00)
                Console.WriteLine("\nISENTO");
            else if (salario >= 2001.00 && salario <= 3000.00)
            {
                calculo8 = (salario - 2000.00) / 100 * 8;
                Console.WriteLine("\nTAXA DE 8%: R$ " + calculo8.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 3001.00 && salario <= 4500.00)
            {
                calculo8 = 1000.00 / 100 * 8;
                calculo18 = (salario - 3000.00) / 100 * 18 + calculo8;
                Console.WriteLine("\nTAXA DE 18%: R$ " + calculo18.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (salario >= 4500.00)
            {
                calculo8 = 1000.00 / 100 * 8;
                calculo18 = 1500.00 / 100 * 18;
                calculo28 = (salario - 4500) / 100 * 28 + calculo8 + calculo18;
                Console.WriteLine("\nTAXA DE 28%: R$ " + calculo28.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.WriteLine("\nFim do Programa!\n");
        }
    }
}
