using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System.Linq;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        public static PizzaListViewModel PizzaToPizzaListViewModel(Pizza pizza)
        {
            return new PizzaListViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSizeEnum = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static PizzaDetailsViewModel ToPizzaDetailsViewModel(this Pizza pizza)
        {
            return new PizzaDetailsViewModel
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Price = pizza.Price,
                PizzaSizeEnum = pizza.PizzaSize,
                IsOnPromotion = pizza.IsOnPromotion
            };
        }

        public static Pizza ToPizza(this PizzaViewModel pizzaViewModel)
        {
            return new Pizza
            {
                Id = pizzaViewModel.Id,
                Name = pizzaViewModel.Name,
                Price = pizzaViewModel.Price,
                PizzaSize = pizzaViewModel.PizzaSizeEnum,
                IsOnPromotion = pizzaViewModel.IsOnPromotion
            };
        }
    }
}
