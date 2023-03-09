
using System.ComponentModel.DataAnnotations.Schema;

namespace UsersInDbWebEf.Models;
public class Address
{
    public int Id { get; set; }
    public string? StreetName { get; set; }
    public int StreetNo { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public bool Primary { get; set; }
    public virtual List<Customer>? Customer { get; set; }
}