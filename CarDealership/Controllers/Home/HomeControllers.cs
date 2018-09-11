using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/home/Homepage")]
    public ActionResult Homepage()
    {
      return View();
    }
    [HttpPost("/home/Homepage")]
    public ActionResult GetData()
    {
      Car newCar = new Car();
      newCar.SetMakeModel(Request.Form["newMakeModel"]);
      newCar.SetCarInfo(Request.Form["newCarInfo"]);
      newCar.SetPrice(Request.Form["newPrice"]);
      newCar.SetMiles(Request.Form["newMiles"]);

      return View("display_car", newCar);
    }
    [HttpGet("/home/display_car")]
    public ActionResult display_car()
    {
      return View();
    }  
  }
}
