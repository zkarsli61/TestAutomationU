using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingWithNunit.Tests
{
    public class AdminPage
    {
        private IWebDriver driver;
        public AdminPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        internal void LogOut()
        {
            throw new NotImplementedException();
        }
        internal void Login()
        {
            throw new NotImplementedException();
        }
        internal List<Room> GetRooms()
        {
            throw new NotImplementedException();
        }
        internal void AddRoom(Room room)
        {
            throw new NotImplementedException();
        }
    }
}
