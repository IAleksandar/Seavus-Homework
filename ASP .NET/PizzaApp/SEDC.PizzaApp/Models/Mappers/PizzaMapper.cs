using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaViewModel PizzaDetailsViewModel(Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                PizzaName = pizza.Name,
                PizzaPrice = pizza.IsOnPromotion ? pizza.HasExtras ? 310 : 300 : pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
                Size = pizza.pizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaViewModel ExtensionMethod(this Pizza pizza)
        {
            return new PizzaViewModel
            {
                Id = pizza.Id,
                PizzaName = pizza.Name,
                PizzaPrice = pizza.IsOnPromotion ? pizza.HasExtras ? 310 : 300 : pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
                Size = pizza.pizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }
    }
}