using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;

namespace CarDealership.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Homepage()
    {
      List<Car> allCars = new List<Car> {};
      return View();
    }
    [HttpPost("/home_page")]
    public ActionResult Index()
    {
      Car myCar = new Car(Request.Form["newMakeModel"], Request.Form["newCarInfo"], Request.Form["newCarInfo"], Request.Form["newMiles"]);
      myCar.Save();
      List<Car> allCars = Car.GetAll();

      return View("Index", allCars);
    }
    // [HttpGet("/home/display_car")]
    // public ActionResult display_car()
    // {
    //   // Car myNewCar = new Car(Request.Form["new-car"]); //Request.Form["new-car"]
    //   // List<Car> allCars = new List<Car> {};
    //
    //   return View();
    // }
  }
}
