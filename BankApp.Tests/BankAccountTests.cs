namespace BankApp.Tests
{
    public class BankAccountTests
    {
    
        [Test]
        [Category("Deposit")]
        public void TestAccountDepositValidSum()
        {
            //1. Arrange
            double initialBalance = 100;
            BankAccount account = new BankAccount(1, initialBalance);

            //2. Act
            double depositAmount = 300;
            account.Deposit(depositAmount);

            double expectedAmount = 400;
            //3. Assert
            Assert.That(account.Balance, Is.EqualTo(expectedAmount), "The balance should be increased by the deposit amount");
        }

        [Test]
        [Category("Deposit")]
        public void TestAccountDepositInvalidSum()
        {
            double initialBalance = 100;
            BankAccount account = new BankAccount(1, initialBalance);

            Assert.Throws<ArgumentException>(() =>
            {
                account.Deposit(-100);
            }, "Account deposit method should not allow negative amount");

        }

        [Test]
        [Category("Deposit")]
        public void TestAccountDepositZeroSum()
        {
            double initialBalance = 100;
            BankAccount account = new BankAccount(1, initialBalance);

            Assert.Throws<ArgumentException>(() =>
            {
                account.Deposit(0);
            }, "Account deposit method should not allow negative amount");
        }

        [Test]
        [Category("Withdraw")]
        public void TestAccountWithdrawMoreThanBalanceThrowsException()
        {
            double initialBalance = 100;
            BankAccount account = new BankAccount(1, initialBalance);

            Assert.Throws<InvalidOperationException>(() => {
                account.Withdraw(1000);
            });
        }
    }
}