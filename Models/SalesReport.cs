
using System.ComponentModel.DataAnnotations.Schema;

public class SalesReport{
    //id, shopid, date, totalsales
    public int Id { get; set; }

    public DateTime Date { get; set; }
    public int TotalSales { get; set; }

    [ForeignKey("SodaShop")]
    public int ShopId { get; set; }
    public required SodaShop SodaShop { get; set; }
}