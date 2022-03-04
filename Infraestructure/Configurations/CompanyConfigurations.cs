using Core.Entities.Company;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configurations
{
    public class CompanyConfigurations: IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(p => p.Name)
                .HasMaxLength(100);
            builder.Property(p => p.Nationality)
                .HasMaxLength(50);
            builder.Property(p => p.Type)
                .HasConversion<string>()
                .IsUnicode(false);
            builder.Property(p => p.Website)
                .HasMaxLength(100);
            builder.Property(p => p.Address)
                .HasMaxLength(100);
            builder.Property(p => p.Reference)
                .HasMaxLength(120);
            builder.Property(p => p.Department)
                .HasMaxLength(50);
            builder.Property(p => p.City)
                .HasMaxLength(20);
            builder.Property(p => p.Neighborhood)
                .HasMaxLength(20);
            builder.Property(p => p.BillingCountry)
                .HasMaxLength(50);
            builder.Property(p => p.BillingCountry)
                .HasMaxLength(50);
            builder.Property(p => p.BillingStreet)
                .HasMaxLength(50);
            builder.Property(p => p.BillingState)
                .HasMaxLength(50);
            builder.Property(p => p.ClientCode)
                .HasMaxLength(20);
            builder.Property(p => p.ClientFont)
                .HasConversion<string>()
                .IsUnicode(false);
            builder.Property(p => p.IsClient)
                .HasConversion<string>()
                .IsUnicode(false);
            builder.Property(p => p.ClientState)
                .HasConversion<string>()
                .IsUnicode(false);
            builder.Property(p => p.LeadsSource)
                .HasConversion<string>()
                .IsUnicode(false);

        }
    }
}