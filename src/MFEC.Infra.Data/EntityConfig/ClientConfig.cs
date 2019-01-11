using MFEC.Domain.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;

namespace MFEC.Infra.Data.EntityConfig
{
    public class ClientConfig : EntityTypeConfiguration<Client>
    {
        public ClientConfig()
        {
            HasKey(c => c.Id);
            // HasKey(c => new { c.Id, c.CPF}); 

            Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("IX_CPF") { IsUnique = true }));

            Property(c => c.BirthDate)
                .IsRequired();

            Property(c => c.Active)
                .IsRequired();

            Property(c => c.Removed)
                .IsRequired();

            ToTable("Clients");
        }
    }
}
