using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Logic.Entities
{
    [Table("Shop", Schema = "bikeshop")]
    [Index(nameof(Location), IsUnique = true)]
    [Index(nameof(Address), IsUnique = true)]
    public class Shop : VersionEntity
    {
        [Required]
        public string Location { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; } = string.Empty;

        public string? GoogleAddressString { get; set; }

        //nav prop.
        public List<Bike> Bikes { get; set; } = new ();
    }
}
