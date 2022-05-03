using BikeShop.Logic.Controllers;
using BikeShop.Logic.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikesController : GenericController<Logic.Entities.Bike, Models.EditBike, Models.Bike>
    {
        public BikesController(Logic.Controllers.BikesController controller) : base(controller)
        {

        }
    }
}
