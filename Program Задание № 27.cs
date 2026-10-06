using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program27  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double cLight = 299792458.0; // скорость света в м/с (сразу double)
            double mKg;

            // Ввод массы с защитой от ошибок
            while (true)
            {
                Console.Write("Масса (кг): ");
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input) &&
                    double.TryParse(input.Trim(), out mKg) &&
                    mKg >= 0)
                {
                    break; // корректный ввод — выходим из цикла
                }

                Console.WriteLine("Ошибка: введите неотрицательное число для массы (например, 1.5).");
            }

            // Расчёт энергии E = mc^2
            double energy = mKg * cLight * cLight; // проще и точнее, чем Math.Pow

            Console.WriteLine($"Энергия: {energy:E2} Дж"); // экспоненциальный формат: 1.23E+17
        }
    }
}