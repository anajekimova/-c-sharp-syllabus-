using Microsoft.VisualStudio.TestTools.UnitTesting;
using Account;
namespace Classes.Account.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var bartosSwissAccount = new AccountPersone("Barto's account in Switzerland", 1000000.00);
            bartosSwissAccount.Deposit(200);
            var expect = "Barto's account in Switzerland: 1000200";

            var atual = bartosSwissAccount.ToString();

            Assert.AreEqual(expect, atual);
        }

        [TestMethod]
        public void MattsDeposide_MattsAccountDeposit_DisplayAfterChanges()
        {
            var matt = new AccountPersone("Matt's account", 1000);
            matt.Withdrawal(100);
            var expect = "Matt's account: 900";

            var actual = matt.ToString();

            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void MyAccount_MyAccountDeposit_DisplayAfterChanges()
        {
            var myAccount = new AccountPersone("My account", 0);
            myAccount.Deposit(100);
            var expect = "My account: 100";

            var actual = myAccount.ToString();

            Assert.AreEqual(expect, actual);        }
    }
}
