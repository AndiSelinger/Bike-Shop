using BikeShop.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.ConApp
{
    partial class Program
    {
        static async partial void BeforeRun()
        {
            var bike = new Logic.Entities.Bike()
            {
                Brand = "Suzuki",
                Type="GSXR", 
                Model="Hayabusa", 
                Vin="VAM34564938473657", 
                Power=175, 
                Ccm=1300, 
                ProductionYear= new DateTime(2005,01,06), 
                Price= 8000, 
                Mileage= 23000, 
                ImageLink= "assets/img/Hayabusa.jpg"
            };

            using var ctrl = new Logic.Controllers.BikesController();
            await ctrl.InsertAsync(bike);
            await ctrl.SaveChangesAsync();
        }
    }
}
