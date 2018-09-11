using System.Collections.Generic;
using System.Collections;

namespace CarDealership.Models
{
  public class Car
  {
      private string _makeModel;
      private string _price;
      private string _miles;
      private string _carInfo;
      //private string _newCar;
      private static List<Car> _instances = new List<Car> {};

      public Car(string newMakeModel, string newCarInfo, string newPrice, string newMiles)
      {
        _makeModel = newMakeModel;
        _carInfo = newCarInfo;
        _price = newPrice;
        _miles = newMiles;
      }

      public void SetMakeModel(string newMakeModel)
      {
          _makeModel = newMakeModel;
      }
      public  string GetMakeModel()
      {
          return  _makeModel;
      }
      public void SetPrice(string newPrice)

        {
          _price = newPrice;
      }
      public string GetPrice()
      {
        return _price;
      }
      public void SetMiles(string newMiles)
      {
        _miles = newMiles;
      }
      public string GetMiles()
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
      public void Save()
      {
        _instances.Add(this);
      }
      public static List<Car> GetAll()
      {
        return _instances;
      }

    }
  }
