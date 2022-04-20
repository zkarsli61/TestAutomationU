using NUnit.Framework;

namespace TestingWithNunit.Tests
{
    [TestFixture]
    public class EqualityAssertions
    {
        [Test]
        public void AreEqual()
        {
            Assert.AreEqual("expected", "actual");
            Assert.That("actual", Is.EqualTo("expected"));
        }

        [Test]
        public void AreEqualWithDescription()
        {
            Assert.AreEqual("expected", "actual","what does this even mean");
        }
        [Test]
        public void AreEqualWithDynamicDescription()
        {
            Assert.AreEqual("expected", "actual", "what does {0} mean to {1}","testing", "you");
        }
        [Test]
        public void AreEqualNumbers()
        {
            //            Assert.AreEqual(1,2);
            //            Assert.AreEqual(2,2d); // it will pass
            Assert.AreEqual(2, 23, .5);
        }

        [Test]
        public void AreEqualArrays()
        {
            var expected = new int[] { 1, 2, 3 };
            var actual = new int[] { 1, 3, 2 };
            Assert.AreEqual(expected,actual);
        }
        public void ContainsOneInstanceOfThree()
        {
            int[] arrayOfValues=new int[] { 1, 2, 4 };
            //            Assert.AreEqual(1, arrayOfValues.GetLength(x => x.Equals(3));
            //           Assert.That(arrayOfValues, Has.One.EqualTo(3));   
            Assert.That(100, Is.GreaterThan(5).And.LessThan(100));

        }
    }
}