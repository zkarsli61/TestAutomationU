using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace TestingWithNunit.Tests;

public class MyFirstNUnitTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public async Task IAmDoingGreat()
    {
        Console.WriteLine("See you in the test output");
        Assert.Pass();
    }
    [Test]
    public  static void ThisIsAStaticTest()
    {

    }

}