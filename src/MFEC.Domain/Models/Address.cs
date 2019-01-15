using System;

namespace MFEC.Domain.Models
{
    public class Address : Entity
    {
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string CEP { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public override bool IsValid()
        {
            return true;
        }

        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
