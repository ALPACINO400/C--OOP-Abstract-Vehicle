// public abstract class BankAccount
// {
//   private string _accountNumber;
//   private string _accountHolder;
//   private int _balance;
//   public string AccountNumber { get { return _accountNumber; } set { _accountNumber = value; } }
//   public string AccountHolder { get { return _accountHolder; } set { _accountHolder = value; } }
//   public int Balance { get { return _balance; } set { _balance = value; } }
//   public BankAccount(string accountNumber, string accountHolder, int balance)
//   {
//     _accountNumber = accountNumber;
//     _accountHolder = accountHolder;
//     _balance = balance;
//   }

//   public virtual void DisplayAccountInfo() {

//       Console.WriteLine($"Account Number:{AccountNumber}\n Account Holder:{AccountHolder}\n balance:{Balance} \n Interest {InterestRate / 100 * Balance}");


//   }




// }
// public class SavingsAccount : BankAccount
// {
//   private double _interestRate;

//   public double InterestRate { get { return _interestRate; } set { _interestRate = value; } }

//   public SavingsAccount(string accountNumber, string accountHolder, int balance, double interestRate) : base(accountNumber, accountHolder, balance)
//   {
//     InterestRate = interestRate;

//   }
//   public void CalculateInterest()
//   {

//   }
//   public override void DisplayAccountInfo()
//   {
//     Console.WriteLine($"Account Number:{AccountNumber}\n Account Holder:{AccountHolder}\n balance:{Balance} \n Interest {InterestRate / 100 * Balance}");

//   }

// }
// public class CheckingAccount : BankAccount
// {
//   private int _overdraftLimit;

//   public CheckingAccount(string accountNumber, string accountHolder, int balance) : base(accountNumber, accountHolder, balance)
//   {
//   }

//   public int OverdraftLimit { get { return _overdraftLimit; } set { _overdraftLimit = value; } }

// }

// public class FixedDepositAccount : BankAccount
// {
//   private double _maturityPeriod;
//   private double _fixedInterestRate;

//   public FixedDepositAccount(string accountNumber, string accountHolder, int balance) : base(accountNumber, accountHolder, balance)
//   {
//   }

//   public double MaturityPeriod { get { return _maturityPeriod; } set { _maturityPeriod = value; } }
//   public double FixedInterestRate { get { return _fixedInterestRate; } set { _fixedInterestRate = value; } }


// }
// public interface IAccountActions
// {
//   public void Deposit();
//   public void Withdraw();
//   public void CalculateInterest();

// }

// class program
// {
//   public static void Main(string[] args)
//   {
//     BankAccount savings = new SavingsAccount("SA12345", "Alice", 1000, 3.5);


//     // BankAccount checking = new CheckingAccount("CA67890", "Bob", 500, 200);
//     // BankAccount fixedDeposit = new FixedDepositAccount("FD54321", "Charlie", 1000, 1);

//   }

// }
abstract class Vehicle
{
  private string _model;
  private string _year;
  private string _fuelType;
  public string Model { get { return _model; } set { _model = value; } }
  public string Year { get { return _year; } set { _year = value; } }
  public string FuelType { get { return _fuelType; } set { _fuelType = value; } }
  public Vehicle(string Model, string Year, string FuelType)
  {
    _model = Model;
    _year = Year;
    _fuelType = FuelType;
  }
  // in abstract method, there is no logics implementation 
  public abstract void DisplayInfo();

  // this method is not abstract, normal method, and this method could be used/called by derived classes car.Start() bike.Start() 
  public void Start()
  {
    Console.WriteLine($"is starting.");

  }
}

