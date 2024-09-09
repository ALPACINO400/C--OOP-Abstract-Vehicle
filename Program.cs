class Program
{
  public static void Main(string[] args)
  {
    var toyota = new Car("Toyota Corolla", "2022", "Petrol", 4);
    Console.Write($"{toyota.Model}  ");
    toyota.Start();

    toyota.DisplayInfo();

    var yamha = new Bike("Yamaha", "2020", "patrol", "yes");
    Console.Write($"{yamha.Model}  ");

    yamha.Start();
    yamha.DisplayInfo();
    var Volvo = new Truck("Volvo ", "2021", "Diesel", 15.5);
    Console.Write($"{Volvo.Model}  ");

    Volvo.Start();
    Volvo.DisplayInfo();
  }
}
