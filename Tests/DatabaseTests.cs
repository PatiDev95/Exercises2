using Episode1.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestFixture]
    class DatabaseTests
    {
        //TDD - test driven development

        public User User;
        public IDatabase Database;

        //Red -> Green -> Refactor

        [SetUp]
        public void Setup()
        {
            User = new User("user1@gmail.com", "secret");
            Database = new Database();
        }



        [Test]
        public void invoking_connect_should_set_is_connected_to_true()
        {
            //Arrange
            

            //Act
            Database.Connect();

            //Assert
            Assert.IsTrue(Database.IsConnected);
        }
    }
}
