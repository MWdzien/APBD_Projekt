using System.ComponentModel.DataAnnotations;

namespace APBD_Projekt1.Models;

public class IndividualClient
{
    [Key]
    public int IndividualClientId { get; set; }
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(100)]
    public string Adress { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    [Phone]
    public int PhoneNumber { get; set; }
    [Required]
    [Length(11, 11)]
    public string PESEL { get; set; }
    public bool IsDeleted { get; set; }
    
}