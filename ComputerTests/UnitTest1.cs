using ComputerStore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ComputerTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BuilderStore store = new BuilderStore();
            PC pc = store.BuildPC(2, true);
            Assert.IsTrue(pc.Price < 600);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestMethod2()
        {
            BuilderStore store = new BuilderStore();
            PC pc = store.BuildPC(1, true);
        }

        [TestMethod]
        public void TestMethod3()
        {
            BuilderStore store = new BuilderStore();
            Assert.ThrowsException<InvalidOperationException>(
                () => { store.BuildPC(1, true); });
        }

    }
}