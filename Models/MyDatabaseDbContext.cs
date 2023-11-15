using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace WebFormMVC.Models
{
    public class MyDatabaseDbContext : DbContext
    {
        public MyDatabaseDbContext()
        {

        }

        public MyDatabaseDbContext(DbContextOptions<MyDatabaseDbContext> options): base(options)
        {

        }


        public DbSet<PersonalDataModel> personalDatas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        }


    }
}
