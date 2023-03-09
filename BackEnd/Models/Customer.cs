
namespace UsersInDbWebEf.Models;
public class Customer
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required int PhoneNumber { get; set; }
    public virtual List<Address> AddressList {get; set;}
}

