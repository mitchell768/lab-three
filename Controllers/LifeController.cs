using Microsoft.AspNetCore.Mvc;

public class LifeController : Controller
{
    public IActionResult Index ()
    {
        //return Ok("This is the index of the Life Insurance Page");
        return View();
    }
        public IActionResult Quote ()
    {
        return Ok("This is the Life Insurance Quote Page");
    }
}
