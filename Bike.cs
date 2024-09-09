class Bike : Vehicle{
  public string HasCarrier{get; set;}
  public Bike(string model, string year, string fuelType,string hasCarrier) : base(model,year,fuelType){
    HasCarrier = hasCarrier;
  }
  
  public override void DisplayInfo(){
 Console.WriteLine($"Bike Model: {this.Model}, Year: {this.Year}, Fuel Type: {this.FuelType}, Carrier: {this.HasCarrier}");
 
  }

}