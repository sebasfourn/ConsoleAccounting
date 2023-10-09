namespace Account;

public class Checking
{
  public int Id { get; set ; } // property
  public decimal Balance { get; set; } = 0;

  public void Output()
  {
    if (Id == 100)
    {
      Console.WriteLine($"Checking balance: {Balance}$");
    }
    else if (Id == 200)
    {
      Console.WriteLine($"Saving balance: {Balance}$");
    }
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

  public void Transfert(decimal value, ref Saving saving)
  {
    Balance -= value;
    saving.Balance += value;
  }
}
