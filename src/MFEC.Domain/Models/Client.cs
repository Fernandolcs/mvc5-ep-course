﻿using System;
using System.Collections.Generic;

namespace MFEC.Domain.Models
{
    public class Client : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
        private bool Active { get; set; }
        private bool Removed { get; set; }

        // EF navigation property
        public virtual ICollection<Address> Address { get; private set; }

        // EF constructor
        protected Client()
        {
            Address = new List<Address>();
        }

        public void Remove()
        {
            Active = false;
            Removed = true;
        }

        public void Activate()
        {
            Active = true;
            Removed = false;
        }

        public override bool IsValid()
        {
            return true;
        }

        public void AddAddress(Address address)
        {
            if (!address.IsValid())
            {
                return;
            }

            Address.Add(address);
        }
    }
}