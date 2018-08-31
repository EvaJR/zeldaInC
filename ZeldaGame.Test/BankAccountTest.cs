using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ZeldaGame.model;

namespace ZeldaGame.Test
{
    [TestClass]
    public class BankAccountTest
    {
        BankAccount bankaccount; // class variable

        [TestInitialize]
        public void SetUp()
        {
            bankaccount = new BankAccount("test", 100);
        }
        
        [TestMethod]
        public void DebitTest()
        {
            
            bankaccount.Debit(10);
            Assert.AreEqual(90, bankaccount.Balance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NegativeAmountDebitTest()
        {
            
            bankaccount.Debit(-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BalanceTooLowDebitTest()
        {
            
            bankaccount.Debit(110);
        }

        [TestMethod]
        public void FreezeAccountTest()
        {
            
            // how to test a private method? Mockitio: spy?
        }

        [TestMethod]
        public void CreditTest()
        {
            
            bankaccount.Credit(10);
            Assert.AreEqual(110, bankaccount.Balance);
        }
    }
}
