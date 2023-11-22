using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project5.Domain.Entities;

namespace Project5.Infrastructure.Persistence.Configuration
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books"); // Assuming the table name is "books"

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(b => b.Author)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(b => b.Year)
                .IsRequired();

            // Additional configurations for other properties if needed
        }
    }
}
