using Account;

Console.WriteLine("Welcome to the Accounting System 1.0.");

Checking newChecking = new Checking(); // object/instance
newChecking.Id = 100;

Premium newPremium = new Premium();
newPremium.Id = 200;

newChecking.Output();
newPremium.Output();

newChecking.Deposit(2000);
newPremium.Deposit(6000);
newChecking.Output();
newPremium.Output();

newPremium.Transfert(2000);
newChecking.Output();
newPremium.Output();

decimal checkingInterest = newChecking.Interest(3m);
decimal premiumInterest = newPremium.Interest(3m);
Console.WriteLine($"Account1 interest: {checkingInterest}");
Console.WriteLine($"Account2 interest: {premiumInterest}");
newChecking.Output();
newPremium.Output();
