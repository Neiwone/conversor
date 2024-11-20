using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor.currency
{
    internal class Currency
    {
        public static List<string> GetErrors(string c)
        {
            List<string> errors = [];

            if (c.Length != 3)
            {
                errors.Add("Moeda deve ter exatamente 3 caracteres.");
            }

            return errors;
        }

        public static List<string> GetErrors(double c)
        {
            List<string> errors = [];

            if (c < 0)
            {
                errors.Add("Valor deve ser maior que zero.");
            }

            return errors;
        }
    }
}
