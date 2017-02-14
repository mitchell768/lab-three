using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

public class LifeController : Controller
{
    public IActionResult Index ()
    {
        //return Ok("This is the index of the Life Insurance Page");
        return View();
    }
        public IActionResult Quote ()
    {
         Quote quote = new Quote{
            ID=346,
            Product = "Life Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        //return Ok("This is the Life Insurance Quote Page");
        return View(quote);
    }
}
