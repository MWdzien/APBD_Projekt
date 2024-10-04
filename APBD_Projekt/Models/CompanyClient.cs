using System.ComponentModel.DataAnnotations;

namespace APBD_Projekt1.Models;

public class CompanyClient
{
    [Key] 
    public int CompanyClientId { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
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
    [Length(9, 14)]
    public string KRSNumber { get; set; }
}