using NUnit.Framework;
using System.Linq;


namespace TestingWithNunit.Tests
{
    public class AdminTests:UITest
    {

        public AdminPage adminPage { get; set; }
       
        [SetUp]
        public  void SetupTest()
        {

            AdminPage adminPage = new AdminPage(driver);
            adminPage.Login();
        }


        [TearDown]
        public void CleanUpTests()
        {
            /*
             Within your SetUp, TearDown, or Test methods, the context is that of the individual test case; 
            but if you use OneTimeSetUps or OneTimeTearDown, the context is going to refer to the fixture as a whole.
            */
            TestContext.WriteLine($"{TestContext.CurrentContext.Result.Outcome.Status}");
            if (TestContext.CurrentContext.Result.Outcome.Status != NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                TestContext.WriteLine($"{TestContext.CurrentContext.Result.Outcome.Label}");
                TestContext.WriteLine($"{TestContext.CurrentContext.Result.Outcome.Site}");

            }
            adminPage.LogOut();
        }
        [Test(Author ="zk",Description ="Admin Test",ExpectedResult = "none")]
        [Category("smoke"),Category("regression"),Order(2),Platform(Exclude ="MacOSX")]
        [TestCaseSource(typeof(TestData), nameof(TestData.RoomInfo))]
        public void AddRoom(
            [Values("9","999")] string roomNumber,
            [Values("100","1000")] string price,
            [Values] bool accesible,
            [Values] RoomType roomType)
        {
            var originalRoomsCount = adminPage.GetRooms().Count;

            TestContext.WriteLine($"Original room count = {originalRoomsCount}");
            TestContext.AddTestAttachment("addRoom.png", "after add room");
            TestContext.WriteLine(TestContext.CurrentContext.Test.Name);

            var room = new Room()
            {
                Number = roomNumber,
                Type = roomType,
                Price = price,
                Accessible = accesible,
                HasWifi = true,
                HasView = true
            };

            adminPage.AddRoom(room);
            var rooms = adminPage.GetRooms();
            var createdRoom = rooms.First(r=>r.Number==room.Number);

            Assert.That(rooms.Count,Is.GreaterThan(originalRoomsCount));
            Assert.That(createdRoom.Price,Is.EqualTo(createdRoom.Price));
            Assert.That(createdRoom.Accessible, Is.True);
            Assert.That(createdRoom.HasWifi, Is.True);
            Assert.That(createdRoom.HasView, Is.True);
            Assert.That(createdRoom.HasRadio, Is.False);
            Assert.That(createdRoom.HasRefreshments, Is.False);
            Assert.That(createdRoom.HasSafe, Is.False);
            Assert.That(createdRoom.HasTelevision, Is.False);




        }
    }
}
