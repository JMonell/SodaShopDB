
using System.ComponentModel.DataAnnotations.Schema;

namespace Models;

public class Company{

    public int CompanyId { get; set; }
    public required string CompanyName { get; set; }
    public string? CompanyPhone { get; set; }
    public required string CompanyEmail { get; set; }

    [ForeignKey("Address")]
    public int AddressId { get; set; }
    public required Address Address{ get; set; }

}