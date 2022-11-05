using System.ComponentModel.DataAnnotations.Schema;

namespace TheMenu.Domain.Entities
{
    [Table("Category")]
    public class Category : BaseEntity
    {
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
