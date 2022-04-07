using AutoMapper;
using OnlinePizzeria.Core.Models;
using OnlinePizzeria.Core.Services.IService;
using OnlinePizzeria.Data;
using OnlinePizzeria.Data.Enum;
using OnlinePizzeria.Data.Models;
using OnlinePizzeria.Infrastructure.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Type = OnlinePizzeria.Data.Enum.Type;

namespace OnlinePizzeria.Core.Services.Service
{
    public class PizzaService : IPizzaService
    {
        private readonly AppDbContext _context;
        private readonly IPizzaRepository pizzaRepository;
        private readonly IMapper mapper;

        public PizzaService(
            IPizzaRepository pizzaRepository,
            IMapper mapper)
        {
            this.pizzaRepository = pizzaRepository;
            this.mapper = mapper;
        }

        public async Task<bool> Update(
            string id,
            string name,
            string description,
            string imageUrl,
            Type type,
            decimal price,
            Category category
            )
        {
            if (!await this.IsPizzaExist(id))
            {
                return false;
            }

            var pizza = new Pizza()
            {
                Id = id,
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                Type = type,
                Price = price,
                Category = category
            };

            this.pizzaRepository
                .Update(pizza);

            await this.pizzaRepository.SaveChangesAsync();

            return true;
        }

        public async Task<Tuple<bool, bool>> Add(
            string name,
            string description,
            string imageUrl,
            Type type,
            decimal price,
            Category category)
        {
            var pizza = new Pizza()
            {
                Name = name,
                Description = description,
                ImageUrl = imageUrl,
                Type = type,
                Price = price,
                Category = category
            };

            await this.pizzaRepository
                .AddAsync(pizza);

            await this.pizzaRepository
                .SaveChangesAsync();

            return new(true, false);
        }

        private async Task<bool> IsPizzaExist(string id)
        => await this.pizzaRepository
                .FindOrDefaultAsync(p => p.Id == id) != null;

        public async Task<PizzaServiceModel> GetByIdOrDefault(string id)
        {
            var pizzaById = await this.pizzaRepository
                .FindOrDefaultAsync(x => x.Id == id);

            return this.mapper.Map<PizzaServiceModel>(pizzaById);
        }

        public IEnumerable<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }
    }
}
