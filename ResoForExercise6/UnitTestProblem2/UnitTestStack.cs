using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTestProblem2
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void TestMethodPush()
        {
            MySimpleStack S = new MySimpleStack(5);
            S.Push(5);
            Assert.AreEqual(1, S.Count);
            S.Push(2);
            S.Push(5);
            Assert.AreEqual(2, S.Count);
        }
    }
}
