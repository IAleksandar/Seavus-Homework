using SEDC.PizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzaApp.Models.ViewModels
{
    public class PizzaViewModel
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public double PizzaPrice { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}