using SEDC.PizzaApp.Domain.Enums;

namespace SEDC.PizzaApp.ViewModels.PizzaViewModels
{
    public class PizzaListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public PizzaSizeEnum PizzaSizeEnum { get; set; }
        public bool IsOnPromotion { get; set; }
    }
}
