
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem1;

namespace UnitTestProblem1
{
    [TestClass]
    public class UnitTestBankAccount
    {
        [TestMethod]
        public void TestMethodBankAccount()
        {
            BankAccount acc = new BankAccount(200000);
            Assert.IsNotNull(acc);
            Assert.IsInstanceOfType(acc, typeof(BankAccount));
            Assert.AreEqual(200000, acc.Balance());
        }

        [TestMethod]
        public void TestMethodWithDraw()
        {
            TestMethodBankAccount();
            BankAccount acc = new BankAccount(150000);
            acc.WithDraw(200000);
            Assert.AreEqual(150000, acc.Balance());
            acc.WithDraw(30000);
            Assert.AreEqual(120000, acc.Balance());
            acc.WithDraw(0);
            Assert.AreEqual(120000, acc.Balance());
        }

        [TestMethod]
        public void TestMethodDeposit()
        {
            TestMethodBankAccount();
            BankAccount acc = new BankAccount(150000);
            acc.Deposit(200000);
            Assert.AreEqual(350000, acc.Balance());
            acc.Deposit(-150);
            Assert.AreEqual(350000, acc.Balance());
            acc.Deposit(0);
            Assert.AreEqual(350000, acc.Balance());
        }
    }
}
