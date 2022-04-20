using FluentAssertions;
using NUnit.Framework;
using System;

namespace TestingWithNunit.Tests
{
    [TestFixture]
    public class AdvancedOptions
    {
        //[Test]
        ////public void UsingWarnings()
        ////{
        ////    var isProcessed = false;
        ////    Warn.Unless(isProcessed, Is.EqualTo(true).After(1).Minutes.PollEvery(10).Seconds);
        ////    Console.WriteLine("still going"); 
        ////}

        ////        public void AssertPassThrowException()
        ////        {
        ////                        Assert.That(Assert.Pass, Throws.Exception);
        //////            Assert.That(Assert.Pass, Throws.TypeOf<AssertionException>());
        ////        }

        //public void Assumptions()
        //{
        //    //            Assert.That(Assert.Pass, Throws.Exception);
        //    Assume.That("a value", Is.EqualTo("this value"));

        //}
        //public void WillThisMakeItThroughCodeReview()
        //{
        //    Assert.Multiple(
        //        () =>
        //            {
        //                Assert.AreEqual(1, 3);
        //                Assert.AreEqual(3, 4);
        //            }
        //    );
        //}

        public void AssertingWithFluentAssertions()
        {
            "actual".Should().Be("expected");
        }
    }
}