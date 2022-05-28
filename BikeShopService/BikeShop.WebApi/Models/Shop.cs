namespace BikeShop.WebApi.Models
{
    public class Shop : IdentityModel
    {
        public string Location { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string? GoogleAddressString { get; set; }
    }
}
