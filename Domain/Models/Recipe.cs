using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetGallery.Domain.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required, StringLength(20)]
        public string Name { get; set; } = string.Empty;
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [StringLength(255)]
        public string CoverPhoto { get; set; } = string.Empty;
        public bool Vegitarian { get; set; }

        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public User? CreatedByUser { get; set; }
    }
}