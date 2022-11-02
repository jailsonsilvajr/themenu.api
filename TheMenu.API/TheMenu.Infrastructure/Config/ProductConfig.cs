using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheMenu.Domain.Entities;

namespace TheMenu.Infrastructure.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            var product1 = new Product(new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "First Product");
            var product2 = new Product(new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "Second Product");
            builder.HasData(product1, product2);
        }
    }
}
