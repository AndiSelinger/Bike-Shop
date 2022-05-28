using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Logic.Entities
{
    [Table("Bike", Schema = "bikeshop")]
    [Index(nameof(Vin), IsUnique = true)]
    public class Bike : VersionEntity
    {
        [Required]
        [MaxLength(128)]
        public string Brand { get; set; } = string.Empty;

        [MaxLength(128)]
        public string? Type { get; set; }

        [Required]
        [MaxLength(128)]
        public string Model { get; set; } = string.Empty;

        [Required] //length is checked in Controller
        public string Vin { get; set; } = string.Empty; //vehicle identification number

        [Required]
        public int Power { get; set; }

        [Required]
        public int Ccm { get; set; }

        [MaxLength(64)]
        public string? Color { get; set; }

        [Required]
        public DateTime ProductionYear { get; set; }

        [Required]
        public double Price { get; set; }
        
        public bool? SpecialModel { get; set; }
        
        public DateTime? LastService { get; set; }
        
        [NotMapped]
        public bool ServiceNeeded 
        {
            get => (DateTime.Now - LastService > TimeSpan.FromDays(365));
        }

        [Required]
        public int Mileage { get; set; }

        public string? ImageLink { get; set; }

        //fk
        public int ShopId { get; set; }

        //nav.prop
        public Shop Shop { get; set; } = new Shop();
    }
}
