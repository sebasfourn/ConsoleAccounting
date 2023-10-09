namespace Account;

public class Premium : Checking
{
  public decimal Interest(decimal value)
  {
    decimal interest = Balance * ((value + 1) / 100);
    Balance += interest;
    return interest;
  }

  public void Transfert(decimal value)
  {
    Balance -= value;
    Checking checkingInstance = new Checking();
    checkingInstance.Balance += value;
  }
}
