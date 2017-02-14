using Microsoft.AspNetCore.Mvc;
using System;
using FisherInsurance.Models;

public class AutoController : Controller
{
    public IActionResult Index()
    {
        //return Ok("This is the index of the Auto Insurance Page");
        return View();
    }

    public IActionResult Quote()
    {
        //return Ok("This is the Auto Insurance Quote Page");
        Quote quote = new Quote{
            ID=345,
            Product = "Auto Insurance",
            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };
        return View(quote);
        
       
    }
}

