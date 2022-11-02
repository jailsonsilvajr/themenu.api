using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheMenu.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; private set; }
        public Guid? RegisteredById { get; private set; }
        public Guid? LastChangeById { get; private set; }

        public BaseEntity() { }
        public BaseEntity(Guid id)
        {
            Id = id;
        }

        public void SetCreatedAt() => CreatedAt = DateTime.UtcNow;
        public void ChangeUpdatedAt() => UpdatedAt = DateTime.UtcNow;
        public void SetRegisteredById(Guid value) => RegisteredById = value;
        public void SetLastChangeById(Guid value) => LastChangeById = value;
    }
}
