using DDDAPI.Infra.schemas;
using Microsoft.EntityFrameworkCore;

namespace DDDAPI.Infra{


public class SqlServerContext : DbContext{

    public SqlServerContext(DbContextOptions<SqlServerContext> opts)
    : base(options: opts) 
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserSchema>(new UserSchemaMap().Configure);
    }
    
  }
}