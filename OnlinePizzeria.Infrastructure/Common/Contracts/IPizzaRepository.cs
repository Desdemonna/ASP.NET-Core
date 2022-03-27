using OnlinePizzeria.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePizzeria.Infrastructure.Common.Contracts
{
    public interface IPizzaRepository : IRepository<Pizza>
    {
        Task<Pizza> GetPizzaWithCategoryById(string id);
        Task<IEnumerable<Pizza>> GetDishesWithCategories();
    }
}
