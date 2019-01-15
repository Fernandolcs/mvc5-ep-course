using System;

namespace MFEC.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        public Entity()
        {
            Id = new Guid();
        }

        public abstract bool IsValid();
    }
}
