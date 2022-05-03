using System.ComponentModel.DataAnnotations;

namespace BikeShop.WebApi.Models
{
    public class Bike : IdentityModel
    {
        [Required]
        public string Brand { get; set; } = string.Empty;

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

        public string? Color { get; set; }

        [Required]
        public DateTime ProductionYear { get; set; }

        [Required]
        public double Price { get; set; }

        public bool? SpecialModel { get; set; }

        public DateTime? LastService { get; set; }

        public bool ServiceNeeded
        {
            get => (DateTime.Now - LastService > TimeSpan.FromDays(365));
        }

        [Required]
        public int Mileage { get; set; }
    }
}
