using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

[ApiController]
[Route("[controller]")]
public class MyTestController : ControllerBase
{

    public MyTestController()
    {
        
    }

    [HttpGet(Name = "GetMyTest")]
    public string Get()
    {


        return "testing my controller out";
    }
}