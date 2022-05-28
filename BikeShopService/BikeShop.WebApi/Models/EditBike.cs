using System.ComponentModel.DataAnnotations;

namespace BikeShop.WebApi.Models
{
    public class EditBike
    {
        public string Brand { get; set; } = string.Empty;

        public string? Type { get; set; }

        public string Model { get; set; } = string.Empty;

        public string Vin { get; set; } = string.Empty; //vehicle identification number

        public int Power { get; set; }

        public int Ccm { get; set; }

        public string? Color { get; set; }

        public DateTime ProductionYear { get; set; }

        public double Price { get; set; }

        public bool? SpecialModel { get; set; }

        public DateTime? LastService { get; set; }

        public bool ServiceNeeded { get; set; }

        public int Mileage { get; set; }

        public string? ImageLink { get; set; }

        //fk
        public int ShopId { get; set; }
    }
}
