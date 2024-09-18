using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MyTestController : ControllerBase
{

    public MyTestController()
    {
        
    }

    [HttpGet(Name = "GetMyTest")]
    public string[] Get()
    {
        string[] results = new string[0];

        foreach(Pizza pizza in PizzaService.GetAll())
        {
            //put the addditioan here once you figure fucking arrays out. too tired
            
        }
        return results;
    }

    // public string Get()
    // {
        
    //     return "hehe";
    // }
}   