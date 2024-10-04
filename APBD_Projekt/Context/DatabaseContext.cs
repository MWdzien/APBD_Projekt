using APBD_Projekt1.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Projekt1.Context;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<IndividualClient> IndividualClients { get; set; }
    public DbSet<CompanyClient> CompanyClients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<IndividualClient>().HasData(new List<IndividualClient>()
        {
            new()
            {
                IndividualClientId = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                Adress = "Wrzosowa 1",
                Email = "jankowalski@gmail.com",
                PhoneNumber = 511111111,
                PESEL = "01010101010"
            },
            new()
            {
                IndividualClientId = 2,
                FirstName = "Kazimierz",
                LastName = "Nowak",
                Adress = "Tulipanowa 1",
                Email = "nowak@gmail.com",
                PhoneNumber = 123124125,
                PESEL = "01010101010"
            }
        });

        modelBuilder.Entity<CompanyClient>().HasData(new List<CompanyClient>()
        {
            new()
            {
                CompanyClientId = 1,
                Name = "Firma1",
                Adress = "Różana 3",
                Email = "firma1@op.pl",
                PhoneNumber = 000000000,
                KRSNumber = "0123456789"
            },
            new()
            {
                CompanyClientId = 2,
                Name = "Firma2",
                Adress = "Konwaliowa 3",
                Email = "firma2@o2.pl",
                PhoneNumber = 898989898,
                KRSNumber = "1111111111"
            }
        });
    }
}