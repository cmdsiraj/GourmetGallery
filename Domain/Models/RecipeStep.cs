using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetGallery.Domain.Models
{
    public class RecipeStep
    {
        public int Id { get; set; }
        [ForeignKey("Recipe")]
        public int RecipeId { get; set; }
        [StringLength(50)]
        public string Description { get; set; } = string.Empty;
        [StringLength(255)]
        public string Image { get; set; } = string.Empty;
        public int StepNumber { get; set; }
        [StringLength(10)]
        public string Duration { get; set; } = string.Empty;
        [StringLength(20)]
        public string Notes { get; set; } = string.Empty;

        public Recipe? Recipe { get; set; }
    }
}
