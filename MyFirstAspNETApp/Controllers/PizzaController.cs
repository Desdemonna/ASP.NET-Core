using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlinePizzeria.Data;
using OnlinePizzeria.Infrastructure.Common.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IPizzaRepository pizzaRep;
        private readonly IMapper mapper;

        public PizzaController(
            IPizzaRepository pizzaRep,
            IMapper mapper)
        {
            this.pizzaRep = pizzaRep;
            this.mapper = mapper;
        }
    }
}
