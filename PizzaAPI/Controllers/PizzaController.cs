using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Model;
using PizzaAPI.Service;
using System.Xml.Linq;

namespace PizzaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaService _pizzaService;

        public PizzaController(PizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }

        /// <summary>
        /// Gets a list of all pizzas.
        /// </summary>
        /// <returns>List of pizzas.</returns>
        [HttpGet(Name = "GetAllPizzas")]
        public IEnumerable<Pizza> GetAllPizzas()
        {
            var pizzas = _pizzaService.GetAllPizzas();
            return pizzas.ToArray();
        }

        [HttpGet("{id}", Name = "GetPizzaById")]
        public IActionResult GetPizzaById(int id)
        {
            var pizza = _pizzaService.GetPizzaById(id);
            if (pizza == null)
            {
                return NotFound();
            }
            return Ok(pizza);
        }

        [HttpPost(Name = "AddPizza")]
        public IActionResult AddPizza(Pizza pizza)
        {
            _pizzaService.AddPizza(pizza);
            return CreatedAtAction(nameof(GetPizzaById), new { id = pizza.Id }, pizza);
        }

        [HttpPut("{id}", Name = "UpdatePizza")]
        public IActionResult UpdatePizza(int id, Pizza pizza)
        {
            _pizzaService.UpdatePizza(id, pizza);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeletePizza")]
        public IActionResult DeletePizza(int id)
        {
            _pizzaService.DeletePizza(id);
            return NoContent();
        }
    }
}
