using OnlinePizzeria.Core.Models;
using OnlinePizzeria.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = OnlinePizzeria.Data.Enum.Type;

namespace OnlinePizzeria.Core.Services.IService
{
    public interface IPizzaService
    {
        Task<IEnumerable<PizzaServiceModel>> All();
        Task<PizzaServiceModel> GetByIdOrDefault(string id);
        Task<bool> Update(
            string id,
            string name,
            string description,
            string imageUrl,
            Type type,
            decimal price,
            Category category
            );

        Task<Tuple<bool, bool>> Add(
            string name,
            string description,
            string imageUrl,
            Type type,
            decimal price,
            Category category);
    }
}
