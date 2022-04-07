using OnlinePizzeria.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.ViewModels
{
    public class SearchViewModel
    {
        [Required]
        [DisplayName("Seаrch")]
        public string SearchText { get; set; }

        public IEnumerable<Pizza> PizzaList { get; set; }
    }
}
