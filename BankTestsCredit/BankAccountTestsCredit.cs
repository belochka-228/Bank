using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankAccountNS;

namespace BankTestsCredit
{
    [TestClass]
    public class BankAccountTestsCredit
    {
        /// <summary>
        /// Пополнение на валидную сумму
        /// </summary> 
        [TestMethod]
        public void Credit_WithValidAmount_UpdatesBalance()
        {
            double beginningBalance = 11.99;
            double creditAmount = 5.00;
            double expected = 16.99;
            BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);

            account.Credit(creditAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not credited correctly");
        }
        /// <summary>
        /// Пополнение на отрицательную сумму
        /// </summary>
        [TestMethod]
        public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
        {
            double beginningBalance = 11.99;
            double creditAmount = -5.00; 
            BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);

            try
            {
                account.Credit(creditAmount);
            }
            catch (ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.CreditAmountLessThanZeroMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
        /// <summary>
        /// Пополнение на ноль
        /// </summary>
        [TestMethod]
        public void Credit_WhenAmountIsZero_UpdatesBalance()
        {
            double beginningBalance = 11.99;
            double creditAmount = 0.00;
            double expected = 11.99; 
            BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);

            account.Credit(creditAmount);

            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Balance should not change when crediting zero");
        }
    }
}
