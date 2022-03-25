using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Data.Models
{
    public class Size
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public decimal Multiplier { get; set; }
    }
}
