using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccounts.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        private BankAccount _bankAccount;
        private readonly double _beginningBalance = 12.0;

        [TestInitialize]
        public void InitTest()
        {
            double beginningBalance = 12.0;

            _bankAccount = new BankAccount("Vova", beginningBalance);
        }

        [TestMethod()]
        [DataRow(4.55, 16.55)]
        [DataRow(3.0, 15.0)]
        public void BankAccountTest(double debitAmount, double expectedResult)
        {
            _bankAccount.Debit(debitAmount);

            Assert.AreEqual(expectedResult, _bankAccount.Balance, $"{expectedResult} doesn't equal with {_bankAccount.Balance}");
        }

        [TestMethod()]
        public void DebitTest()
        {
            double debitAmount = -4.55;

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _bankAccount.Debit(debitAmount));
        }

        [TestMethod()]
        public void CreditTest()
        {

        }
    }
}