using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestTutorial;

namespace BankTests
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double BeginningBalance = 11.99;
            double DebitAmount = 4.55;
            double Expected = 7.44;
            BankAccount Account = new BankAccount("Ryan Mueller", BeginningBalance);

            Account.Debit(DebitAmount);

            double Actual = Account.Balance;
            Assert.AreEqual(Expected, Actual, 0.001, "Account not debited correctly");
        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double BeginningBalance = 11.99;
            double DebitAmount = -100.00;
            BankAccount Account = new BankAccount("Ryan Mueller", BeginningBalance);
            try
            {
                Account.Debit(DebitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountLessThanZeroMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void DDebit_WhenAmountIsMoreThanBalance_ShouldThrowArgumentOutOfRange()
        {
            double BeginningBalance = 11.99;
            double DebitAmount = 100.00;
            BankAccount Account = new BankAccount("Ryan Mueller", BeginningBalance);

            try
            {
                Account.Debit(DebitAmount);
            }catch(System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }
            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
