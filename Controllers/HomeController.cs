using Microsoft.AspNetCore.Mvc;
using System;

public class HomeController : Controller
{
    public IActionResult Index ()
    {
        //return Ok("This is the index of the HomeController");
        return View();
    }
}
