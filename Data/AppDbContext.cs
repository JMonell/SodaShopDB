using System;
using Microsoft.EntityFrameworkCore;
using Models;
public class AppDbConext : DbContext{

    public DbSet<Company> Companies { get; set; }
    public DbSet<Soda> Sodas { get; set; }
    public DbSet<Storage> Storages { get; set; }
    public DbSet<SodaShop> SodaShops { get; set; }
    public DbSet<SalesReport> SalesReports { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<StorageSoda> StorageSoda { get; set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        // The name of the DataBase is called "WinterBreak_HospitalSystem".
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SodaShop;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        
    }
}