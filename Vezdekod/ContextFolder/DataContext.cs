using Microsoft.EntityFrameworkCore;
using Vezdekod.Models;

namespace Vezdekod.ContextFolder;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
    @"workstation id=vezdekodDb.mssql.somee.com;
                         packet size=4096;
                         user id=alan-vezdekod_SQLLogin_1;
                         pwd=jjg7cf84ku;
                         data source=vezdekodDb.mssql.somee.com;
                         persist security info=False;
                         initial catalog=vezdekodDb"
                    );

        
    }
}
