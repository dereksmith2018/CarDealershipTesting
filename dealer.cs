using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;
  private string _carInfo;

  public  void SetMakeModel(string newMakeModel){
      _makeModel = newMakeModel;
  }
  public  string GetMakeModel(){
      return  _makeModel;
  }
  public void SetPrice(int newPrice)
  {
    if (newPrice >= 0){
      _price = newPrice;
    }
    else{
      Console.WriteLine("You cheep checky bastard!!!");
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


public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);
    porsche.SetCarInfo("You will fee like a kid again driving this beast");

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);
    ford.SetCarInfo("Found on road dead");

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);
    lexus.SetCarInfo("Over pirced Honda/Toyota");

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);
    mercedes.SetCarInfo("Over Priced BMW");

    Car pos = new Car();
    pos.SetMakeModel("Piece o' Shit");
    pos.SetPrice(100);
    pos.SetMiles(450000);
    pos.SetCarInfo("Pefect for street parking. Who cares if you get hit.");

    List<Car> Cars = new List<Car>() { porsche, ford, lexus, mercedes, pos };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);

    Console.WriteLine("Enter maximum miles: ");
    string stringMaxMiles = Console.ReadLine();
    int maxMiles = int.Parse(stringMaxMiles);

    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.GetPrice() < maxPrice && automobile.GetMiles() < maxMiles)
      {
        CarsMatchingSearch.Add(automobile);
      }

      }

       if(CarsMatchingSearch.Count == 0)
      {
        Console.WriteLine("no car");
        }




    foreach(Car automobile in CarsMatchingSearch)
    {

      Console.WriteLine(automobile.GetMakeModel());
      Console.WriteLine(automobile.GetCarInfo());
    }
  }
}
