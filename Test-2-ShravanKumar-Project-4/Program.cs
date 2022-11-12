// See https://aka.ms/new-console-template for more information
using Test_2_ShravanKumar_Project_4;



try
{
    BankOpeartions objBankOpeartions = new();
    Console.WriteLine("Enter your Bank Account Details");
    Console.WriteLine("\nGreetings AccountHolder   Welcome to CSharp Bank");
    objBankOpeartions.GetBankAccountDetails();
    int choice = -1;
    do
    {
        Console.WriteLine("you can perform Bank operations  now.\n\t 1. Account Details\n\t 2.Deposit\n\t 3.Withdraw Cash\n\t 4. Display Balance\n\t 5. Clear Console\n\t 6.Close Bank Operations\n\nChoose Your Option....");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                objBankOpeartions.DisplayBankAccountDetails();
                break;
            case 2:
                objBankOpeartions.Deposit();
                break;
            case 3:
                objBankOpeartions.WithDraw();
                break;
            case 4:
                objBankOpeartions.DisplayBalance();
                break;
            case 5:
                Console.Clear();
                break;
        }
    }
    while (choice < 6);
    Console.WriteLine(" Closed..........Press Enter Again for Exit The Console");
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}