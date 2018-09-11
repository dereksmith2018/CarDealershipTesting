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
      Car myNewCar = new Car(); //Request.Form["new-car"]
      List<Car> allCars = new List<Car> {};

      newCar.SetMakeModel(Request.Form["newMakeModel"]);
      newCar.SetCarInfo(Request.Form["newCarInfo"]);
      newCar.SetPrice(Request.Form["newPrice"]);
      newCar.SetMiles(Request.Form["newMiles"]);

      return View("display_car", allCars);
    }
    [HttpGet("/home/display_car")]
    public ActionResult display_car()
    {
      return View();
    }
  }
}
