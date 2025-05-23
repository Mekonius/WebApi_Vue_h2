using Microsoft.EntityFrameworkCore;
using pizzaStoreApi.Models;

namespace pizzaStoreApi.Data 
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options) { }

        public DbSet<Pizza> Pizzas {get; set; }
    }
}