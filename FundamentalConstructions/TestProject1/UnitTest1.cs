using BankAccounts;

namespace BankAccountNUnitTests
{
    [TestFixture]
    public class UnitTest1
    {
        private BankAccount _bankAccount;

        [SetUp]
        public void InitTest()
        {
            double beginningBalance = 12.0;

            _bankAccount = new BankAccount("Vova", beginningBalance);
        }

        [Test]
        public void BankAccountTest()
        {
            double debitAmount = 4.55;
            double expectedResult = 15.55;
            _bankAccount.Debit(debitAmount);

            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedResult, _bankAccount.Balance, $"{expectedResult} doesn't equal with {_bankAccount.Balance}");
                Assert.IsTrue(false);
            });
        }
    }
}