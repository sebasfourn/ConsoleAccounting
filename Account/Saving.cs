namespace Account;

public class Saving : Checking
{
  public decimal Interest(decimal value)
  {
    decimal interest = Balance * ((value + 1) / 100);
    Balance += interest;
    return interest;
  }

  public void Transfert(decimal value, ref Checking checking)
  {
    Balance -= value;
    checking.Balance += value;
  }
}
