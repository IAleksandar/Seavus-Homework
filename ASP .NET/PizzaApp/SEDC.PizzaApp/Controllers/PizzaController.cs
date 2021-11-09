using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> pizzas = StaticDb.Pizzas;
            List<PizzaViewModel> pizzaViewModels = pizzas.Select(x => x.ExtensionMethod()).ToList();
            return View(pizzaViewModels); //we send the list to the view

        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return new EmptyResult();
            }
            PizzaViewModel pizzaViewModel = PizzaMapper.PizzaDetailsViewModel(pizza);
            ViewBag.PizzaViewModel = pizzaViewModel;
            ViewData["Title"] = "Pizza Details";
            return View(pizzaViewModel);
        }




        [Route("SeePizzas")] //localhost:[port]/SeePizzas
        public IActionResult Redirect()
        {
            return RedirectToAction("Index");
        }
    }
}