using NUnit.Framework;

namespace BuildAPileOfCubes.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(2022, Kata.findNb(4183059834009));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(-1, Kata.findNb(24723578342962));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(4824, Kata.findNb(135440716410000));
        }
        [Test]
        public void Test4()
        {
            Assert.AreEqual(3568, Kata.findNb(40539911473216));

        }
    }
}