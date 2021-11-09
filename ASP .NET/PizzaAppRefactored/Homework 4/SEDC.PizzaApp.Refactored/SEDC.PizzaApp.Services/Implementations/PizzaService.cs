using SEDC.PizzaApp.DataAccess.Interfaces;
using SEDC.PizzaApp.Domain.Models;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Services.Interfaces;
using SEDC.PizzaApp.ViewModels.PizzaViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.PizzaApp.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepository;

        public PizzaService(IRepository<Pizza> pizzaRepository)
        {
            _pizzaRepository = pizzaRepository;
        }

        public void CreatePizza(PizzaViewModel pizzaViewModel)
        {
            Pizza pizzaDb = _pizzaRepository.GetById(pizzaViewModel.Id);
            if (pizzaDb == null)
            {
                throw new Exception($"Pizza with id {pizzaViewModel.Id} was not found!");
            }
        }

        public List<PizzaListViewModel> GetAllPizza()
        {

            List<Pizza> dbPizzas = _pizzaRepository.GetAll();
            return dbPizzas.Select(x => PizzaMapper.PizzaToPizzaListViewModel(x)).ToList();
        }

        public PizzaDetailsViewModel GetPizzaDetails(int id)
        {
            Pizza pizzaDb = _pizzaRepository.GetById(id);
            if (pizzaDb == null)
            {
                throw new Exception($"The pizza with id {id} was not found!");
            }
            return pizzaDb.ToPizzaDetailsViewModel();
        }
    }
}
