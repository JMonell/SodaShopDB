
using System.ComponentModel.DataAnnotations.Schema;
using Models;

public class StorageSoda{
    public int StorageSodaId { get; set; }
    
    [ForeignKey("Storage")]
    public int StorageId { get; set; }
    public Storage? Storage { get; set; }

    [ForeignKey("Soda")]
    public int SodaId { get; set; }
    public Soda? Soda { get; set; }
}