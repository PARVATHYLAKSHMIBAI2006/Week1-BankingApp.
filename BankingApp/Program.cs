using System.Xml.Serialization;

void BuildBankingApp()
{ 
    int choice;
    double depositAmount;
    double accountBalance = 1000.00;
    Console.WriteLine("Building BankingApp...");
    Console.WriteLine(" PLEASE CHOOSE AN OPTION:");
    Console.WriteLine("============================");
    Console.WriteLine("1. Deposit or withdraw funds ");
    Console.WriteLine("2. View current account information");
    Console.WriteLine("PLEASE CHOOSE AN OPTION");


    choice = Convert.ToInt32(Console.ReadLine());

    if (choice== 1)
    {
        Console.WriteLine("You chose to deposit or withdraw funds.");
        Console.WriteLine("How much do u want to deposit?");
        Console.WriteLine("ENTER THE AMOUNT INCLUDING PENCE USING THE DECIMAL POINT");
        depositAmount = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Your original balance is {accountBalance}");

        accountBalance += depositAmount;
        Console.WriteLine($"Your new balance is {accountBalance}");

    }
    else if (choice == 2)
    {
        Console.WriteLine("You chose to view current account information.");
        
    }
    else
    {
        Console.WriteLine("Invalid choice. Please try again.");
    }



}
BuildBankingApp();
