using System;

namespace MFEC.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public abstract bool IsValid();
    }
}
