using Account;

int choice = 0;

do
{
  Console.WriteLine("Welcome to the Accounting System 1.0.");
  Console.WriteLine("1. Start");
  Console.WriteLine("2. Quit");
  string choiceString = Console.ReadLine();
  choice = int.Parse(choiceString);

  if (choice == 1)
  {
    Checking newChecking = new Checking(); // object/instance
    newChecking.Id = 100;

    Premium newPremium = new Premium();
    newPremium.Id = 200;

    int userChoice = 0;

    do
    {
      newChecking.Output();
      newPremium.Output();

      Console.WriteLine("1. Make a deposit");
      Console.WriteLine("2. Make a transfert");
      Console.WriteLine("3. Add interests");
      Console.WriteLine("4. Go back");
      string userChoiceString = Console.ReadLine();
      userChoice = int.Parse(userChoiceString);

      switch (userChoice)
      {
        case 1:
          Console.WriteLine("Choose the account:");
          Console.WriteLine("1. Checking");
          Console.WriteLine("2. Premium");
          string depositAccountChoiceString = Console.ReadLine();
          int depositAccountChoice = int.Parse(depositAccountChoiceString);

          Console.WriteLine("Enter the amount:");
          string depositAmountString = Console.ReadLine();
          decimal depositAmount = decimal.Parse(depositAmountString);

          switch (depositAccountChoice)
          {
            case 1:
              newChecking.Deposit(depositAmount);
            break;

            case 2:
              newPremium.Deposit(depositAmount);
            break;
          }
        break;

        case 2:
          Console.WriteLine("From which account:");
          Console.WriteLine("1. Checking");
          Console.WriteLine("2. Premium");
          string transfertAccountChoiceString = Console.ReadLine();
          int transfertAccountChoice = int.Parse(transfertAccountChoiceString);

          Console.WriteLine("Enter the amount:");
          string transfertAmountString = Console.ReadLine();
          int transfertAmount = int.Parse(transfertAmountString);

          switch (transfertAccountChoice)
          {
            case 1:
              newChecking.Transfert(transfertAmount);
            break;

            case 2:
              newPremium.Transfert(transfertAmount);
            break;
          }
        break;

        case 3:
          Console.WriteLine("Enter the %:");
          string interestString = Console.ReadLine();
          decimal interest = decimal.Parse(interestString);
          Console.WriteLine($"Checking account interests: {newChecking.Interest(interest)}$");
          Console.WriteLine($"Premium account interests: {newPremium.Interest(interest)}$");
        break;
      }
    } while (userChoice != 4);
  }
} while (choice != 2);

Console.WriteLine("Goodbye!");
