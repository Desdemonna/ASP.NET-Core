using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.ViewModels
{
    public class PizzaSearchModel
    {
        public string SearchTerm { get; init; }

        [Display(Name = "Order")]
        public byte OrderNumber { get; init; }

        public int CurrentPageNumber { get; init; } = 1;

        [BindNever]
        public int LastPageNumber { get; init; }

        [BindNever]
        public IEnumerable<AllPizzaViewModel> Pizzas { get; init; } = new List<AllPizzaViewModel>();
    }
}
