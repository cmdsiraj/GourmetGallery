using System.ComponentModel.DataAnnotations.Schema;

namespace GourmetGallery.Domain.Models
{
    public class RecipeCategoryMapping
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int CategoryId { get; set; }

        [ForeignKey(nameof(RecipeId))]
        public ICollection<Recipe>? Recipe { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public ICollection<RecipeCategory>? Category { get; set; }
    }
}