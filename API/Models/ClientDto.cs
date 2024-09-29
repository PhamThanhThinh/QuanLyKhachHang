using System.ComponentModel.DataAnnotations;

namespace API.Models
{
  public class ClientDto
  {
    [Required(ErrorMessage = "First Name la truong du lieu bat buoc")]
    public string FirstName { get; set; } = "";
    [Required(ErrorMessage = "Last Name la truong du lieu bat buoc")]
    public string LastName { get; set; } = "";
    [Required, EmailAddress]
    public string Email { get; set; } = "";
    [Phone]
    public string? Phone { get; set; } = "";
    public string? Address { get; set; } = "";
    [Required]
    public string Status { get; set; } = "";
    // New, Permanent, Lead, Occasional, Inactive, Active
    // Khach hang moi, khach hang co dinh, khach hang tiem nang, tai khoan khong con hoat dong, tai khoan dang hoat dong
  }
}
