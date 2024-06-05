using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightSearch.Domain.ValueObjects
{
    public record Airline
    {
    
        public string code { get; set; }
        public string name { get; set; }
        private Airline(string code, string name)
        {
            this.code = code;
            this.name = name;
        }
        public static Airline Of(string code, string name)
        {
           return new Airline(code, name);
        }
    }
}
