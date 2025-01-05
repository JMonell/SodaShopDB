
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public enum Availability{
    yes, no
}
public class Soda{

    public int Id { get; set; }
    public string SodaName { get; set; }
    public int Price { get; set; }
    public required Availability Availability { get; set; }
    
    [ForeignKey("Company")]
    public int CompanyId { get; set; }
    public required Company Company { get; set; }

}