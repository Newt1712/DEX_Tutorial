using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarterDex.Domain.Entities
{
    public class TokenNativePrice
    {
        public string Value { get; set; }
        public int Decimals { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Address { get; set; }
    }
}
