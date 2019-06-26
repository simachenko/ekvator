using System;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
namespace DAL
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Room> Rooms { set; get; }
        public DbSet<Event> Events { set; get; }
        public DbSet<Order> Orders { set; get; }
        public DbSet<Client> Clients { set; get; }
        public DbSet<User> Users { set; get; }

        protected DataBaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
    }
}
