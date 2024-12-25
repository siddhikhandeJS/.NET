using BookProject.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookProject.Repositories;

public class CollectionContext: DbContext{
    public DbSet<Book> Books{get;set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        string ConnectionString=@"server=localhost; port=3306; username=root; password=root123; database=transflower";
        optionsBuilder.UseMySql(ConnectionString,ServerVersion.AutoDetect("8.0.23"));
    }

}