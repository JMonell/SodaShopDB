
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.Identity.Client.Extensions.Msal;

public class SodaShop{

    public int Id { get; set; }
    public string ShopName { get; set; }
    
    [ForeignKey("Storage")]
    public int StorageId { get; set; }
    public required Storage Storage { get; set; }

    [ForeignKey("Address")]
    public int AddressId { get; set; }
    public required Address Address { get; set; }

}