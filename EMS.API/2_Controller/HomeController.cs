using Microsoft.AspNetCore.Mvc;

namespace EMS.API.Controller;

[Route("/")]
[ApiController]
public class HomeController : ControllerBase 
{


    [HttpGet]
    public IActionResult WelcomeToEMS() 
    {
        IActionResult VerbStatus = Ok("Please Login for more options"); 
        
        return VerbStatus;
    }


}