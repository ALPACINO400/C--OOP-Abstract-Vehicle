class Car : Vehicle
{

  public int NumberOfDoors { get; set; }

  // create an object of Car
  // var toyota = new Car("sedan", "2019", "diesel", 4);
  public Car(string model, string year, string fuelType, int numberOfDoors) : base(model, year, fuelType)
  {
    NumberOfDoors = numberOfDoors;
  }
  
  public override void DisplayInfo()
  {
    Console.WriteLine($"Car Model: {this.Model}, Year: {this.Year}, Fuel Type: {this.FuelType}, Doors: {this.NumberOfDoors}");
  }
}