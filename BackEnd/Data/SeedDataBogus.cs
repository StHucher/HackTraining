using Bogus;
using Microsoft.EntityFrameworkCore;
using UsersInDbWebEf.Models;
public static class SeedDataBogus
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new ApplicationDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
        {
            // Look for any customers.
            if (context.Customer.Any()) { return; }
            context.Customer.AddRange(
                new Faker<Customer>()
                .RuleFor(n => n.Name, f => f.Name.FullName())
                .RuleFor(n => n.Email, f => f.Internet.Email())
                .RuleFor(n => n.PhoneNumber, f => f.PickRandom(1, 50000))
                .Generate(5));

            // if (context.Address.Any()) { return; }
            context.Address.AddRange(
                new Faker<Address>()
                .RuleFor(u => u.StreetName, f => f.Address.StreetName())
                .RuleFor(u => u.StreetNo, f => f.Random.Int())
                .RuleFor(u => u.City, f => f.Address.City())
                .RuleFor(u => u.Country, f => f.Address.Country())
                .RuleFor(u => u.Primary, f => f.IndexFaker == 1)
                .Generate(5));

            context.SaveChanges();
        }
    }
}