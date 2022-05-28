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

        [HttpGet("Query", Name =nameof(GetBikesByShopId))]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public virtual async Task<ActionResult<Models.Bike>> GetBikesByShopId(
            [FromQuery(Name ="BikeShopId")] int? shopId
            )
        {
            var ctrl = Controller as Logic.Controllers.BikesController;
            if (ctrl == null)
                return Ok(Array.Empty<Models.Bike>());

            var result = await ctrl.QueryByShopIdAsync(shopId);

            return Ok(result.Select(e => ToModel(e)));
        }
    }
}
