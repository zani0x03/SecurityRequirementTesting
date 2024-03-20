using Microsoft.AspNetCore.Mvc;

namespace SecurityRequirementTesting.Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{

    private readonly ILogger<CustomerController> _logger;

    public CustomerController(ILogger<CustomerController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("getAddress")]
    public ActionResult GetAddress()
    {
        try{
            return NotFound(new{
                message = "TodoItem not found!!"
            });
        }catch(Exception ex){
            _logger.LogError(ex, "General error");
            return StatusCode(500, "Internal server error");            
        }     
    } 
}