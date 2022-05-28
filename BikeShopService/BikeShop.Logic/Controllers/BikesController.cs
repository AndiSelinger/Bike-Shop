using BikeShop.Logic.Entities;
using BikeShop.Logic.Modules.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Logic.Controllers
{
    public class BikesController : GenericController<Entities.Bike>
    {
        public BikesController()
        {
        }

        public BikesController(ControllerObject other) : base(other)
        {
        }

        protected override void ValidateEntity(ActionType actionType, Bike entity)
        {
            if (entity.Vin.Length != 17)  //VIN is 17 digits
                throw new LogicException("The VIN has to be 17 characters long");
            if (entity.Power < 0)
                throw new LogicException("The power can't be lower than 0");
            if (entity.Ccm < 0)
                throw new LogicException("The CCM can't be lower than 0");
            if (entity.ProductionYear.Year < 1900)
                throw new LogicException("Please check the production year");
            if (entity.Price < 0)
                throw new LogicException("The price can't be lower than 0");
            if (entity.LastService < entity.ProductionYear)
                throw new LogicException("Please check the date of the last service");
            if (entity.Mileage < 0)
                throw new LogicException("Mileage can't be lower than 0");
        }

        public Task<Entities.Bike[]> QueryByShopIdAsync(int? shopId)
        {
            var result = EntitySet.AsQueryable();

            if (shopId != null)
                result = result.Where(e => e.ShopId == shopId);

            return result.AsNoTracking().ToArrayAsync();
        }
    }
}
