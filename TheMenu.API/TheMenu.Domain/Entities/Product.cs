namespace TheMenu.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; private set; }

        public void SetName(string name) => Name = name;
    }
}
