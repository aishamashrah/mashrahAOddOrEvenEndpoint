using Microsoft.AspNetCore.Mvc;

namespace mashrahAOddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class NewController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh6")]

    public string OrE()
    {
        return " The user will pick two numbers output will say if its odd or even";
    }
}
