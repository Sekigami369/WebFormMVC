using Microsoft.EntityFrameworkCore;

namespace WebFormMVC.Models
{
    public class MyDatabaseDbContext : DbContext
    {
        public DbSet<PersonalDataModel> personalDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer();
        }
    }
}
