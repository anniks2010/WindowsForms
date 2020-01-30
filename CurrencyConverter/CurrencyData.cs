using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrencyData
    {
        public string Date { get; set; }

        public Rates rates { get; set; }

        public class Rates
        {
            public double AUD { get; set; }
            public int EUR { get; set; }
            public double RUB { get; set; }
            public double SEK { get; set; }
            public double USD { get; set; }
            public double PLN { get; set; }
        }
    }
}
