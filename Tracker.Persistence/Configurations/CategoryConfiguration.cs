using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tracker.Domain.Entities;

namespace Tracker.Persistence.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id).HasConversion(
            categoryId => categoryId.Value,
            value => new CategoryId(value)
        );

        builder.Property(c => c.Name).HasMaxLength(100);
    }
}