using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlinePizzeria.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePizzeria.Configuration
{
    public class PizzaConfiguration : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.HasData(
                new Pizza
                {
                    Id = "1",
                    Name = "Margarita",
                    Description = "Tomato Sauce, Extra Mozzarella",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Eq_it-na_pizza-margherita_sep2005_sml-2.png",
                    Type = Data.Enum.Type.Vegetarian,
                    Price = 7,
                    Category = Data.Enum.Category.Standart
                },
                new Pizza
                {
                    Id = "2",
                    Name = "Pepperoni",
                    Description = "Tomato Sauce, Extra Mozzarella, Extra Pepperoni",
                    ImageUrl = "https://freepikpsd.com/file/2019/10/pepperoni-pizza-png-Transparent-Images.png",
                    Type = Data.Enum.Type.NonVegetarian,
                    Price = 10,
                    Category = Data.Enum.Category.Standart
                },
                new Pizza
                {
                    Id = "3",
                    Name = "Hawaii",
                    Description = "Tomato Sauce, Mozzarella, Smoked Ham, Pineapple",
                    ImageUrl = "https://www.pngkit.com/png/full/340-3401739_hola-hawaiian-pizza-hawaiian-png.png",
                    Type = Data.Enum.Type.NonVegetarian,
                    Price = 9,
                    Category = Data.Enum.Category.New
                },
                new Pizza
                {
                    Id = "4",
                    Name = "Carbonara",
                    Description = "Cream Sauce, Mozzarella, Smoked Bacon, Fresh Mushrooms",
                    ImageUrl = "https://www.tugo.es/wp-content/uploads/2020/05/carbonara.png",
                    Type = Data.Enum.Type.NonVegetarian,
                    Price = 11,
                    Category = Data.Enum.Category.New
                },
                new Pizza
                {
                    Id = "5",
                    Name = "4 cheese",
                    Description = "Tomato Sauce, Feta Cheese, Cheddar Cheese, Mozzarella, Parmesan",
                    ImageUrl = "https://www.downloadclipart.net/large/cheese-pizza-png-clipart.png",
                    Type = Data.Enum.Type.Vegetarian,
                    Price = 9,
                    Category = Data.Enum.Category.Standart
                },
                new Pizza
                {
                    Id = "6",
                    Name = "Garden Classic",
                    Description = "Tomato Sauce, Mozzarella, Black Olives, Fresh Tomato, Onion, Fresh Mushrooms, Fresh Green Peppers",
                    ImageUrl = "https://stonepizzas.com/wp-content/uploads/2016/10/veg_small.png",
                    Type = Data.Enum.Type.Vegetarian,
                    Price = 8,
                    Category = Data.Enum.Category.New
                }
                );
        }
    }
}
