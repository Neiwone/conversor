using conversor.currency;
using conversor.models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace conversor.ui
{
    internal class UserInterface
    {
        public static Tuple<string, string, double> GetUserInput()
        {
            List<string> errors;

            string? basecurrency;
            do
            {
                Console.Write("Moeda origem: ");
                basecurrency = Console.ReadLine();
                if (basecurrency == null || basecurrency == "")
                {
                    Environment.Exit(0);
                }
                errors = Currency.GetErrors(basecurrency);
                if (errors.Count > 0)
                {
                    foreach (var e in errors)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            while (errors.Count != 0);


            string targetcurrency;
            do
            {
                Console.Write("Moeda destino: ");
                targetcurrency = Console.ReadLine();
                errors = Currency.GetErrors(targetcurrency);
                if (errors.Count > 0)
                {
                    foreach (var e in errors)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            while (errors.Count != 0);

            double value;
            do
            {
                Console.Write("Valor: ");
                value = double.Parse(Console.ReadLine().Replace(',', '.'));
                errors = Currency.GetErrors(value);
                if (errors.Count > 0)
                {
                    foreach (var e in errors)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            while (errors.Count != 0);

            Console.WriteLine();

            return Tuple.Create(basecurrency, targetcurrency, value);
        }

        public static void UserOutput(API_Response response)
        {
            string basecurrency = response.base_code;
            double value = Math.Truncate((double.Parse(response.conversion_result) / double.Parse(response.conversion_rate)) * 100) / 100.0;
            string targetcurrency = response.target_code;
            double convertedvalue = Math.Truncate(double.Parse(response.conversion_result) * 100) / 100.0;
            double tax = Math.Truncate(double.Parse(response.conversion_rate) * 1000000) / 1000000.0;

            Console.WriteLine($"{basecurrency} {string.Format("{0:N2}", value)} => {targetcurrency} {string.Format("{0:N2}", convertedvalue)}");
            Console.WriteLine($"Taxa: {string.Format("{0:N6}", tax)}");
            Console.WriteLine();
        }
    }


}
