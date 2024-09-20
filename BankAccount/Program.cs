namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            //Skapa ett BankAccount-objekt
            BankAccount account1 = new BankAccount("12345678", "Filippa Nilsson", 20000);
            BankAccount account2 = new BankAccount("87654321", "Linnea Hansson", 30000);
            BankAccount account3 = new BankAccount("24681357", "Linn Olsson", 100000);
            BankAccount account4 = new BankAccount("13572468", "Lova Gustavsson", 15000);


            //Skapa en lista med alla konton
            List<BankAccount> accountList = new List<BankAccount>
            {
                account1,
                account2,
                account3,
                account4
            };

            //account1.Deposit();

            //account1.Withdraw();

            //account1.DisplayBalance();
        }
    }
}
