﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheMenu.Domain.Entities;

namespace TheMenu.Infrastructure.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
            (
                new Product
                {
                    Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
                    Name = "First Product",
                    CategoryId = new Guid("80abbca8-664d-4b20-b5de-024705497d4a")
                },
                new Product
                {
                    Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
                    Name = "Second Product",
                    CategoryId = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a")
                }
            );
        }
    }
}
