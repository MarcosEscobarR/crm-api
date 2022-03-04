using Core.Entities.Contact;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Configurations
{
  
public class ContactConfigurations : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.Property(p => p.Nationality)
            .HasMaxLength(20);
        builder.Property(p => p.FirstName)
            .HasMaxLength(30);
        builder.Property(p => p.LastName)
            .HasMaxLength(30);
        builder.Property(p => p.Email)
            .HasMaxLength(50);
        builder.Property(p => p.SecondaryEmail)
            .HasMaxLength(50);
        builder.Property(p => p.Phone)
            .HasMaxLength(20);
        builder.Property(p => p.Landline)
            .HasMaxLength(20);
        builder.Property(p => p.Mobile)
            .HasMaxLength(20);
        builder.Property(p => p.Phone)
            .HasMaxLength(20);
        builder.Property(p => p.Reference)
            .HasMaxLength(100);
        builder.Property(p => p.Department)
            .HasMaxLength(20);
        builder.Property(p => p.City)
            .HasMaxLength(20);
        builder.Property(p => p.Neighborhood)
            .HasMaxLength(50);
        builder.Property(p => p.MailingCity)
            .HasMaxLength(30);
        builder.Property(p => p.MailingCountry)
            .HasMaxLength(30);
        builder.Property(p => p.MailingState)
            .HasMaxLength(30);
        builder.Property(p => p.MailingStreet)
            .HasMaxLength(30);
        builder.Property(p => p.WorkPhone)
            .HasMaxLength(30);
        builder.Property(p => p.WorkPlace)
            .HasMaxLength(30);
        builder.Property(p => p.AssistantEmail)
            .HasMaxLength(50);
        builder.Property(p => p.AssistantName)
            .HasMaxLength(30);
        builder.Property(p => p.AssistantPhone)
            .HasMaxLength(40);
        builder.Property(p => p.CurrentSalary)
            .HasMaxLength(20);
        builder.Property(p => p.EconomicActivity)
            .HasMaxLength(40);
        builder.Property(p => p.Description)
            .HasMaxLength(40);
        builder.Property(p => p.Address)
            .HasMaxLength(50);
        builder.Property(p => p.HomeNumber)
            .HasMaxLength(20);
        builder.Property(p => p.IsClient)
            .HasConversion<string>();
        builder.Property(p => p.DocumentType)
            .HasConversion<string>();
        builder.Property(p => p.DocumentType)
            .HasMaxLength(20);
    }
}
}