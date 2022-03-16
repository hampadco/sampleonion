using Microsoft.EntityFrameworkCore;

public class Context:DbContext
{
    
    public DbSet<Product> products { get; set; }
    

    protected override void OnConfiguring(DbContextOptionsBuilder db)
    {
     db.UseSqlServer("Data Source=.;initial Catalog=test1;integrated Security=true");
                      
    }
    
}