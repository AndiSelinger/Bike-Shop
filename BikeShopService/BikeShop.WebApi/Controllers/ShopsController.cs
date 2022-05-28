using BikeShop.Logic.Controllers;
using BikeShop.Logic.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : GenericController<Logic.Entities.Shop, Models.EditShop, Models.Shop>
    {
        public ShopsController(Logic.Controllers.ShopsController controller) : base(controller)
        {
        }
    }
}
