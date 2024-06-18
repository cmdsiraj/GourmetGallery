using System.ComponentModel.DataAnnotations;

namespace GourmetGallery.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string FirstName { get; set; } = string.Empty;
        [StringLength(20)]
        public string LastName { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string Password { get; set; } = string.Empty;
        public bool EmailConfirmed { get; set; } = false;
        public bool Status { get; set; } = false;
    }
}
