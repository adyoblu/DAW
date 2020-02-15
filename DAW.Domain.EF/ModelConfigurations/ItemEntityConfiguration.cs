using DAW.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAW.Domain.EF.ModelConfigurations
{
    public class ItemEntityConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasIndex(c => c.Id);
        }
    }
}