using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LawBuddy.Domain.Users;

public class User
{
    public User(Guid id, string name, string email, string password, DateTime birthDate, string? profilePicture)
    {
        Id = id;
        Name = name;
        Email = email;
        Password = password;
        BirthDate = birthDate;
        ProfilePicture = profilePicture;
    }

    [Key]
    public Guid Id { get; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public DateTime BirthDate { get; set; }

    [NotMapped]
    public int Age 
    {
        get 
        {
            var age = DateTime.Now.Year - BirthDate.Year;
            if(BirthDate.Date > DateTime.Now.AddYears(-age)) age--;
            return age;
        }
    }
    public string? ProfilePicture { get; set; }
}
