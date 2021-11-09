using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System.Collections.Generic;

namespace SEDC.PizzaApp.Services.Interfaces
{
    public interface IPizzaService
    {
        void CreatePizza(PizzaViewModel pizzaViewModel);
        List<PizzaListViewModel> GetAllPizza();
        PizzaDetailsViewModel GetPizzaDetails(int id);
    }
}
