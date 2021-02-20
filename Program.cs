using System;
using TrainingCSharp.classincsharp;

namespace TrainingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Find Binary List */
            /* BinaryNumber.init(3); */

            /* Find sub Array from parent Array */
            /*List<int> input = new List<int> { 1, 2, 3, 4, 5 };
            SubArray.init(input, 2);*/

            /* Fins Permutation List */
            /*List<int> input = new List<int> { 1, 2, 3 };
            Permutation.init(input);*/

            /* OOP */
            /*List<BankAccount> listAccount = new List<BankAccount>();
            BankAccount account = new BankAccount("LocNb", 1000000);
            BankAccount account1 = new BankAccount("LocNb2", 1000023);
            BankAccount account2 = new BankAccount("LocNb3", 100000033);
            listAccount.Add(account);
            listAccount.Add(account1);
            listAccount.Add(account2);


            foreach (BankAccount acc in listAccount)
            {
                Console.WriteLine($"Account {acc.Number} was created for {acc.Owner} with {acc.Balance} initial balance.");
            }*/

            /*var giftCard = new GiftCardAccount("gift card", 100, 50);
            giftCard.MakeWithdrawal(20, DateTime.Now, "get expensive coffee");
            giftCard.MakeWithdrawal(50, DateTime.Now, "buy groceries");
            giftCard.PerformMonthEndTransactions();
            // can make additional deposits:
            giftCard.MakeDeposit(27.50m, DateTime.Now, "add some additional spending money");
            Console.WriteLine(giftCard.GetAccountHistory());*/

            /*var savings = new InterestEarningAccount("savings account", 10000);
            savings.MakeDeposit(750, DateTime.Now, "save some money");
            savings.MakeDeposit(1250, DateTime.Now, "Add more savings");
            savings.MakeWithdrawal(250, DateTime.Now, "Needed to pay monthly bills");
            savings.PerformMonthEndTransactions();
            Console.WriteLine(savings.GetAccountHistory());*/

            var lineOfCredit = new LineOfCreditAccount("line of credit", 0, 2000);
            // How much is too much to borrow?
            lineOfCredit.MakeWithdrawal(1000m, DateTime.Now, "Take out monthly advance");
            lineOfCredit.MakeDeposit(50m, DateTime.Now, "Pay back small amount");
            lineOfCredit.MakeWithdrawal(5000m, DateTime.Now, "Emergency funds for repairs");
            lineOfCredit.MakeDeposit(150m, DateTime.Now, "Partial restoration on repairs");
            lineOfCredit.PerformMonthEndTransactions();
            Console.WriteLine(lineOfCredit.GetAccountHistory());

            Console.ReadKey();
        }
    }
}
