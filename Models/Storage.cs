

using System.ComponentModel.DataAnnotations.Schema;

public class Storage{
    public int Id { get; set; }
    public int Capacity { get; set; }

    [ForeignKey("SodaShop")]
    public int ShopId { get; set; }
    public required SodaShop SodaShop { get; set; }
}