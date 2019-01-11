using MFEC.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace MFEC.Infra.Data.EntityConfig
{
    public class AddressConfig : EntityTypeConfiguration<Address>
    {
        public AddressConfig()
        {
            HasKey(c => c.Id);
            // HasKey(c => new { c.Id, c.CPF}); 

            Property(c => c.Street)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(c => c.Number)
                    .IsRequired()
                    .HasMaxLength(150);

            Property(c => c.District)
                    .IsRequired();

            Property(c => c.CEP)
                    .IsRequired();

            Property(c => c.City)
                    .IsRequired();

            Property(c => c.State)
                    .IsRequired();

            ToTable("Addressess");
        }
    }
}
