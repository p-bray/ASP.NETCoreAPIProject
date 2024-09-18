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

}