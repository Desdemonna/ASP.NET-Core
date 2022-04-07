using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.ViewModels
{
    public class CartListingViewModel
    {
        public IList<AllPizzaViewModel> Pizzas { get; set; } = new List<AllPizzaViewModel>();
    }
}
