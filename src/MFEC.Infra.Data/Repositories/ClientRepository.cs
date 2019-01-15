using MFEC.Domain.Interfaces;
using MFEC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MFEC.Infra.Data.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {

        public Client GetByCpf(string cpf)
        {
            return GetAll(c => c.CPF == cpf && !c.Removed).FirstOrDefault();
        }

        public IEnumerable<Client> GetAllActive()
        {
            return GetAll(c => c.Active && !c.Removed);
        }

        public Client GetByEmail(string email)
        {
            return GetAll(c => c.Email == email && !c.Removed).FirstOrDefault();
        }

        /// <summary>
        /// Logical remove method
        /// </summary>
        /// <param name="id">Client id</param>
        public override void Remove(Guid id)
        {
            var client = GetById(id);
            client.Remove();
            Update(client);
        }
    }
}
