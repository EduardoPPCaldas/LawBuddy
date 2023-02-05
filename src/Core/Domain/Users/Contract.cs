using System.ComponentModel.DataAnnotations;
using Lombok.NET;

namespace LawBuddy.Domain.Users;

[NoArgsConstructor]
public class Contract
{
    public Contract(Guid id, string code, decimal value, string description, string norm, Address address)
    {
        Id = id;
        Code = code;
        Value = value;
        Description = description;
        Norm = norm;
        Address = address;
    }

    [Key]
    public Guid Id { get; }

    [Required]
    public string Code { get; private set; }

    [Required]
    public decimal Value { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public string Norm { get; set; }

    [Required]
    public Address Address { get; set; }
}
