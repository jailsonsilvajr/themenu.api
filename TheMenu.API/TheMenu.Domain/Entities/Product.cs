using System.ComponentModel.DataAnnotations.Schema;

namespace TheMenu.Domain.Entities
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        public string Name { get; private set; }

        public Product() { }
        public Product(Guid id, string name) : base (id)
        {
            Name = name;
        }

        public void SetName(string name) => Name = name;
    }
}
