using System.ComponentModel.DataAnnotations;

namespace GourmetGallery.Domain.Models
{
    public class RecipeCategory
    {
        public int Id { get; set; }
        [StringLength(15), Required]
        public string Name { get; set; } = string.Empty;
    }
}
