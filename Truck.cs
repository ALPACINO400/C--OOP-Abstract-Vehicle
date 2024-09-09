class Truck : Vehicle{
  public double LoadCapacity{get; set;}
  public Truck(string model, string year, string fuelType,double loadCapacity):base(model,year,fuelType)
  {
    LoadCapacity = loadCapacity;
  }
  public override void DisplayInfo()
  {
    Console.WriteLine($"Truck Model: {this.Model}, Year: {this.Year}, Fuel Type: {this.FuelType}, loadCapacity: {this.LoadCapacity}");
    
  }
}