using OnlinePizzeria.Core.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePizzeria.Core.Services.Service
{
    public class PizzaPriceCalculater : IPizzaPriceCalculater
    {
        public decimal Calculate(decimal size, decimal pizzaType, int number)
        {
            decimal price = (pizzaType * size) * number;

            return price;
        }
    }
}
