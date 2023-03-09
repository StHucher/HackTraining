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
            // context.Customer.AddRange(
            var customers =
            new Faker<Customer>()
            .RuleFor(n => n.Name, f => f.Name.FullName())
            .RuleFor(n => n.Email, f => f.Internet.Email())
            .RuleFor(n => n.PhoneNumber, f => f.PickRandom(1, 50000))
            .Generate(5);


            // if (context.Address.Any()) { return; }
            // context.Address.AddRange(
            var address =
                new Faker<Address>()
                .RuleFor(u => u.StreetName, f => f.Address.StreetName())
                .RuleFor(u => u.StreetNo, f => f.Random.Int())
                .RuleFor(u => u.City, f => f.Address.City())
                .RuleFor(u => u.Country, f => f.Address.Country())
                .RuleFor(u => u.Primary, f => f.IndexFaker == 1)
                .Generate(5);

            context.Address.AddRange(address);
            // context.Customer
            foreach (var customer in customers)
            {
                var random = new Random();
                var index = random.Next(address.Count());
                var index2 = random.Next(address.Count());
                customer.AddressList = new List<Address>() { address[index], address[index2] };
            }
            context.Customer.AddRange(customers);


            context.SaveChanges();
        }
    }
}