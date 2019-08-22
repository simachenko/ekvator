using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
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
        public DbSet<AccessType> AccessTypes { set; get; }
        public DataBaseContext() {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\lutik\\source\\repos\\Check2CORE\\DAL\\mydb.db;");
        }


    }
}
