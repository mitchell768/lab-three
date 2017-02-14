using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;
public class PropertyController : Controller
{
    public IActionResult Index ()
    {
        //return Ok("This is the index of the Home Insurance Page");
        return View();
    }

        public IActionResult Quote ()
    {
         Quote quote = new Quote{
            ID=347,
            Product = "Home Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        //return Ok("This is the Home Insurance Quote Page");
        return View(quote);
    }
}
