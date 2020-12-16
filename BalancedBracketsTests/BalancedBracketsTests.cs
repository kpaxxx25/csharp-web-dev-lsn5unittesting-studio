using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void OnlyBracketsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void EmptyStringTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(" "));
        }
        [TestMethod]
        public void StringTrue1()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void StringTrue2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void StringTrue3()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }



        [TestMethod]
        public void FirstBracketOnlyFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        
        [TestMethod]
        public void BackwardsBracketFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
               
        [TestMethod]
        public void FirstBracketStringFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void BackwardsBracketStringFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void IsStringTrue()
        {
            Assert.AreEqual(string, typeof(BalancedBrackets.HasBalancedBrackets("FIX THIS"));
        }

    }
}


//passed param is string
// loop: string == [ && ]

