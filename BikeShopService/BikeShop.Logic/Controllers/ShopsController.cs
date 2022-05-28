using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Logic.Controllers
{
    public sealed class ShopsController : GenericController<Entities.Shop>
    {
        public ShopsController()
        {
        }

        public ShopsController(ControllerObject other) : base(other)
        {
        }
    }
}
