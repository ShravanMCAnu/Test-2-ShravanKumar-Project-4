namespace Test_2_ShravanKumar_Project_4
{
    internal class BankOpeartions : IBank, ITransactions
    {
        public int AccountNumber { get; set; }
        public string? AccountHolderName { get; set; }
        public double Balance { get; set; }
        public void GetBankAccountDetails()
        {
            Console.WriteLine("Enter Account Number");
            AccountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name");
            AccountHolderName = Console.ReadLine();
        }
        public void DisplayBankAccountDetails()
        {
            Console.WriteLine("Account Number:" + AccountNumber);
            Console.WriteLine("Enter Account Holder name:" + AccountHolderName);
            DisplayBalance();
        }
        public void Deposit()
        {
            Console.WriteLine("Enter Amount For Deposit:");
            double TransactionAmount = int.Parse(Console.ReadLine());
            Balance = Balance + TransactionAmount;
            Console.WriteLine("Deposit Completed........");
        }
        public void WithDraw()
        {
            Console.WriteLine("Enter Amount For Withdrawral.....");
            double TransactionAmount = int.Parse(Console.ReadLine());
            if (Balance > 0)
            {
                Balance = Balance - TransactionAmount;
                Console.WriteLine("Cash Withdrawed ........");
            }
            else
            {
                Console.WriteLine("Your Balance is " + Balance + " .Cash Withdraw Failed Due to insufficient balance.......");
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Balance:" + Balance);
        }
    }
}


