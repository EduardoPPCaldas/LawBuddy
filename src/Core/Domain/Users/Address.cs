using System.ComponentModel.DataAnnotations;

namespace LawBuddy.Domain.Users;

public class Address
{
    public Address(Guid id, string street, string code, int number)
    {
        Id = id;
        Street = street;
        Code = code;
        Number = number;
    }

    [Key]
    public Guid Id { get; }

    [Required]
    public string Street { get; set; }

    [Required]
    public string Code { get; set; }
    
    [Required]
    public int Number { get; set; }
}