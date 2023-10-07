namespace Account;

public class Checking
{
  public int Id { get; set ; } // property
  public decimal Balance { get; set; } = 0;

  public void Output()
  {
    Console.WriteLine($"The account with id '{Id}' has a balance of: {Balance}");
  }

  public void Deposit(decimal value)
  {
    Balance += value;
  }

  public decimal Interest(decimal value)
  {
    decimal interest = Balance * (value / 100);
    Balance += interest;
    return interest;
  }

  public void Transfert(decimal value)
  {
    Balance -= value;
  }
}
