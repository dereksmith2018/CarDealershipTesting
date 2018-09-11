using System;
using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Display
  {
    class Car
    {
      private string _makeModel;
      private int _price;
      private int _miles;
      private string _carInfo;
      //private string _newCar;
      private static List<Car> _instances = new List<Item> {};

      public Car (string makeModel, string carInfo, int newPrice, int newMiles)
      {
        _makeModel = makeModel;
        _carInfo = newCarInfo;
        _price = newPrice;
        _miles = newMiles;
      }
      public  void SetMakeModel(string newMakeModel)
      {
          _makeModel = newMakeModel;
      }
      public  string GetMakeModel()
      {
          return  _makeModel;
      }
      public void SetPrice(int newPrice)
      {
        if (newPrice >= 0)
        {
          _price = newPrice;
        }
        else
        {
          Console.WriteLine("You cheep checky `bastard!!!");
        }
      }
      public int GetPrice()
      {
        return _price;
      }
      public void SetMiles(int newMiles)
      {
        _miles = newMiles;
      }
      public int GetMiles()
      {
        return _miles;
      }
      public void SetCarInfo(string newCarInfo)
      {
        _carInfo = newCarInfo;
      }
      public string GetCarInfo()
      {
        return _carInfo;
      }

    }
  }
}
