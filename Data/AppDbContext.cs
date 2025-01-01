using System;
using Microsoft.EntityFrameworkCore;
using Models;
public class AppDbConext : DbContext{

    public DbSet<Company> Companies { get; set; }
    



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        // The name of the DataBase is called "WinterBreak_HospitalSystem".
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SodaShop;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

    }
}