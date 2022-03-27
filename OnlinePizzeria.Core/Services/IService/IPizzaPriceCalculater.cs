using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePizzeria.Core.Services.IService
{
    public interface IPizzaPriceCalculater
    {
        decimal Calculate(decimal size, decimal pizzaType, int number);
    }
}
