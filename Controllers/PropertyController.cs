using Microsoft.AspNetCore.Mvc;

public class PropertyController : Controller
{
    public IActionResult Index ()
    {
        return Ok("This is the index of the Home Insurance Page");
    }

        public IActionResult Quote ()
    {
        return Ok("This is the Home Insurance Quote Page");
    }
}
