using System.ComponentModel.DataAnnotations.Schema;

namespace TheMenu.Domain.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public string? Name { get; set; }

        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
