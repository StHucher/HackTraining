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
                .RuleFor(n => n.Name, f=> f.Name.FullName())
                .RuleFor(n => n.Email, f => f.Internet.Email())
                .RuleFor(n=> n.PhoneNumber , f => f.PickRandom(1,50000))
                .Generate(5)
                // {
                //     Name = "Stephane",
                //     Email = "steph@salt.se",
                //     PhoneNumber = 123456,
                // }
            );
            // Faker.
//             var faker = new Faker<User>()
//    .RuleFor(u => u.Name, f => f.Name.FullName())
//    .RuleFor(u => u.Occupation, f => f.PickRandom(occupations));
            context.SaveChanges();
        }
    }
}