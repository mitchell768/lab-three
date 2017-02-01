using Microsoft.AspNetCore.Mvc;

public class LifeInsuranceController : Controller
{
    public IActionResult Index ()
    {
        return Ok("This is the index of the Life Insurance Page");
    }
        public IActionResult Quote ()
    {
        return Ok("This is the Life Insurance Quote Page");
    }
}
