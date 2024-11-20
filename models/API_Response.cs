using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversor.models
{
    internal class API_Response
    {
        public string result { get; set; }
        public string base_code { get; set; }
        public string target_code { get; set; }
        public string conversion_rate { get; set; }
        public string conversion_result { get; set; }
        
    }
}
