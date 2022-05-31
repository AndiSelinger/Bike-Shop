using Microsoft.VisualStudio.TestTools.UnitTesting;
using BikeShop.Logic.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeShop.Logic.UnitTest;
using BikeShop.Logic.Entities;

namespace BikeShop.Logic.Controllers.UnitTests
{
    [TestClass()]
    public class BikesControllerUnitTests : EntityUnitTest<Entities.Bike>
    {
        public override GenericController<Bike> CreateController()
        {
            return new Controllers.BikesController();
        }

        [TestInitialize]
        public async Task TestInitialize()
        {
            await DeleteControllerEntities();
        }

        [TestMethod()]
        public async Task BikesControllerTest()
        {
            var bike = new Logic.Entities.Bike()
            {
                Brand = "Suzuki",
                Type = "GSXR",
                Model = "Hayabusa",
                Vin = "VAM34564938473657",
                Power = 175,
                Ccm = 1300,
                ProductionYear = new DateTime(2005, 01, 06),
                Price = 8000,
                Mileage = 23000,
                ImageLink = "assets/img/Hayabusa.jpg"
            };
            await Create_OfEntity_AndCheck(bike);
        }
    }
}