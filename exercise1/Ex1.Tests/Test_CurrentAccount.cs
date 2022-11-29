using Microsoft.VisualStudio.TestTools.UnitTesting;
using Banking;

namespace Ex1.UnitTests
{
    [TestClass]
    public class Test_CurrentAccount
    {
        [TestMethod]
        public void Test_AccountNumber()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            Assert.AreEqual("Account1", c.AccountNumber.ToString());
        }

        [TestMethod]
        public void Test_AccountBalance_NewAccount()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            Assert.AreEqual(0.0M, c.AccountBalance);
        }

        [TestMethod]
        public void Test_AccountBalance_MakeDeposit1()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            c.MakeDeposit(2.50M);
            Assert.AreEqual(2.5M, c.AccountBalance);
        }

        [TestMethod]
        public void Test_AccountBalance_MakeDeposit2()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            c.MakeDeposit(2.50M);
            c.MakeDeposit(2.50M);
            c.MakeDeposit(2.50M);
            Assert.AreEqual(7.5M, c.AccountBalance);
        }

        [TestMethod]
        public void Test_AccountBalance_MakeDeposit3()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            c.MakeDeposit(2.50M);
            c.MakeDeposit(2000000000000000.50M);
            c.MakeDeposit(2.50M);
            Assert.AreEqual(2000000000000005.5M, c.AccountBalance);
        }

        [TestMethod]
        public void Test_AccountBalance_MakeWithdrawal1()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            c.MakeWithdrawal(20000000M);
            Assert.AreEqual(-20000000M, c.AccountBalance);
        }

        [TestMethod]
        public void Test_AccountBalance_MakeDepositAndWithdrawal1()
        {
            CurrentAccount c = new CurrentAccount("Account1");
            c.MakeDeposit(2M);
            c.MakeWithdrawal(20M);
            c.MakeDeposit(2M);
            Assert.AreEqual(-16M, c.AccountBalance);
        }
    }
}