using practicemvc.Entities;
using Microsoft.EntityFrameworkCore;

namespace practicemvc.Repositories;

public class CollectionContext:DbContext{
    public DbSet<Product> Products{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string ConnectionString=@"server=localhost;  port=3306; user=root; password=root123; database=transflower";
        optionsBuilder.UseMySql(ConnectionString);
    }

}