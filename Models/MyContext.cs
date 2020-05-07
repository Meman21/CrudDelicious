using Microsoft.EntityFrameworkCore;

namespace CrudDelicious
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options): base(options) {}
        public DbSet<Dish> Dishes {get;set;}
    }
}