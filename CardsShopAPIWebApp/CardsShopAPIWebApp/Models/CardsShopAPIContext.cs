using Microsoft.EntityFrameworkCore;

namespace CardsShopAPIWebApp.Models
{
    public class CardsShopAPIContext : DbContext
    {

        public virtual DbSet<CardDecks>  CardDecks { get; set; }
        public virtual DbSet<Firms> Firms { get; set; }
        public  virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<Reviews> Reviews { get; set; }

        public CardsShopAPIContext(DbContextOptions<CardsShopAPIContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
