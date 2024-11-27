using Microsoft.VisualStudio.TestTools.UnitTesting;
using Luftkvalitet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luftkvalitet.Tests
{
    [TestClass()]
    public class MeassurementTests
    {
        Meassurement meassurement1;
        Meassurement meassurement2;
        Meassurement meassurement3;
        Meassurement meassurement4;
        Meassurement meassurement5;
        Meassurement meassurement6;

        [TestInitialize]
        public void Setup()
        {
            meassurement1 = new Meassurement() { Id = 1, CO2 = 0, Humidity = 100, Location = "Her", Time = DateTime.Now };
            meassurement2 = new Meassurement() { Id = 2, CO2 = -1, Humidity = 69, Location = "Her", Time = DateTime.Now };
            meassurement3 = new Meassurement() { Id = 3, CO2 = 650, Humidity = 101, Location = "Her", Time = DateTime.Now };
            meassurement4 = new Meassurement() { Id = 4, CO2 = 650, Humidity = 100, Time = DateTime.Now };
            meassurement5 = new Meassurement() { Id = 5, CO2 = 650, Humidity = 100, Location = "Her" };
            meassurement6 = new Meassurement() { Id = 6, CO2 = 650, Humidity = -1, Location = "Her", Time = DateTime.Now };

        }
        [TestMethod()]
        public void ValidateTest()
        {
            meassurement1.Validate();
            Assert.ThrowsException<Exception>(()=>meassurement2.Validate());
            Assert.ThrowsException<Exception>(() => meassurement3.Validate());
            Assert.ThrowsException<Exception>(() => meassurement4.Validate());
            Assert.ThrowsException<Exception>(() => meassurement5.Validate());
            Assert.ThrowsException<Exception>(() => meassurement6.Validate());
        }
    }
}