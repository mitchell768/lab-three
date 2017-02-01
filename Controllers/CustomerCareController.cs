using Microsoft.AspNetCore.Mvc;

public class CustomerCareController : Controller
{
    public IActionResult Index ()
    {
        return Ok("This is the index of the Customer Care Page");
    }
        public IActionResult Claims ()
    {
        return Ok("This is the Claims Page");
    }
}
