using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using TodoListWebApplication.Models;

namespace TodoListWebApplication.Configurations
{
    public class TodoConfig : IEntityTypeConfiguration<Todo>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Todo> builder)
        {
            // Configure the primary key
            builder.HasKey(t => t.Id);
            // Configure properties
            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(t => t.Description)
                .HasMaxLength(500);
            builder.Property(t => t.IsCompleted)
                .HasDefaultValue(false);
            builder.Property(t => t.Deadline)
                .IsRequired();
            builder.Property(t => t.CreatedAt)
                .HasDefaultValueSql("GETUTCDATE()");
            // Configure the foreign key relationship with Category
            builder.HasOne(t => t.Category)
                .WithMany(c => c.Todos)
                .HasForeignKey(t => t.CategoryId);
        }
    }
}
