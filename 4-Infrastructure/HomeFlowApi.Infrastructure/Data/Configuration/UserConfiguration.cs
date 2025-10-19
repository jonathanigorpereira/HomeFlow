using HomeFlowApi.Core.Entitie;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HomeFlowApi.Infrastructure.Data.Configuration;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired()
            .HasMaxLength(200);
        
        builder.Property(x => x.Cpf).IsRequired()
            .HasMaxLength(11);
        
        builder.Property(x => x.Phone).IsRequired()
            .HasMaxLength(20);
        builder.Property(x => x.BirthDate).IsRequired()
            .HasColumnType("date");
        
        builder.Property(x => x.Email).IsRequired()
            .HasMaxLength(180)
            .HasConversion(x => x.ToLower(), x => x.ToLower());
        
        builder.Property(x => x.Password).IsRequired()
            .HasMaxLength(255);
        
        builder.Property(x => x.IsActive).IsRequired()
            .HasDefaultValue(true);
        
        builder.Property(x => x.CreatedAt).IsRequired()
            .HasDefaultValueSql("CURRENT_TIMESTAMP")
            .ValueGeneratedOnAdd()
            .HasColumnType("timestamp with time zone");
        
        builder.Property(x => x.UpdatedAt)
            .IsRequired(false)
            .HasColumnType("timestamp with time zone");
        
        builder.HasIndex(x => x.Email).IsUnique()
            .HasDatabaseName("IDX_EMAIL");
    }
}