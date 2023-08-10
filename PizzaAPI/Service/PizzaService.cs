
using PizzaAPI.Model;

namespace PizzaAPI.Service
{
    public class PizzaService
    {
        private List<Pizza> _pizzas = new List<Pizza>();

        public PizzaService()
        {
            _pizzas.Add(new Pizza { Id = 1, Name = "Margherita",Size = 28, Price = 9.99M });
            _pizzas.Add(new Pizza { Id = 2, Name = "Pepperoni", Size = 36, Price = 12.50M });
        }

        public List<Pizza> GetAllPizzas()
        {
            return _pizzas;
        }

        public Pizza GetPizzaById(int id)
        {
            return _pizzas.FirstOrDefault(p => p.Id == id);
        }

        public void AddPizza(Pizza pizza)
        {
            pizza.Id = _pizzas.Count + 1;
            _pizzas.Add(pizza);
        }

        public void UpdatePizza(int id, Pizza pizza)
        {
            var existingPizza = _pizzas.FirstOrDefault(p => p.Id == id);
            if (existingPizza != null)
            {
                existingPizza.Name = pizza.Name;
                existingPizza.Size = pizza.Size;
                existingPizza.Price = pizza.Price;
            }
        }

        public void DeletePizza(int id)
        {
            var pizzaToRemove = _pizzas.FirstOrDefault(p => p.Id == id);
            if (pizzaToRemove != null)
            {
                _pizzas.Remove(pizzaToRemove);
            }
        }
    }
}
