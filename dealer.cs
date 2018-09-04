using System;
using System.Collections.Generic;

class Car
{
  private string _makeModel;
  private int _price;
  private int _miles;

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

}


public class Program
{
  public static void Main()
  {
    Car porsche = new Car();
    porsche.SetMakeModel("2014 Porsche 911");
    porsche.SetPrice(114991);
    porsche.SetMiles(7864);

    Car ford = new Car();
    ford.SetMakeModel("2011 Ford F450");
    ford.SetPrice(55995);
    ford.SetMiles(14241);

    Car lexus = new Car();
    lexus.SetMakeModel("2013 Lexus RX 350");
    lexus.SetPrice(44700);
    lexus.SetMiles(20000);

    Car mercedes = new Car();
    mercedes.SetMakeModel("Mercedes Benz CLS550");
    mercedes.SetPrice(39900);
    mercedes.SetMiles(37979);

    Car pos = new Car();
    pos.SetMakeModel("Piece of Shit");
    pos.SetPrice(100);
    pos.SetMiles(450000);

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

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.GetMakeModel());
    }
  }
}
