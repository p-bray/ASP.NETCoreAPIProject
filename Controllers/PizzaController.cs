using ContosoPizza.Models;
using ContosoPizza.Controllers;
using Microsoft.AspNetCore.Mvc;
using ContosoPizza.Services;
using System.Reflection.Metadata.Ecma335;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }   

    [HttpGet]
    public ActionResult<List<Pizza>> GetAll()
    {
        return PizzaService.GetAll();
    } 

    [HttpGet("{id}")]    
    public ActionResult<Pizza>? Get(int id)
    {   
        var pizza = PizzaService.Get(id);

        if(pizza == null)
            return NotFound();

        return pizza;
    }


    [HttpGet("count")]
    public ActionResult<int> Count()
    {
        return PizzaService.GetAll().Count;
    }

    [HttpPost]
    public IActionResult Create(Pizza pizza)
    {
        PizzaService.Add(pizza);

        return CreatedAtAction(nameof(Get), new {id = pizza.Id}, pizza);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza)
    {
        if (id != pizza.Id)
            return BadRequest();

        var existingPizza = PizzaService.Get(id); 
        if(existingPizza is null)
            return NotFound();

        PizzaService.Update(pizza);

        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var pizza = PizzaService.Get(id);

        if(pizza is null)
            return NotFound();

        PizzaService.Delete(id);

        return NoContent();
    }
}