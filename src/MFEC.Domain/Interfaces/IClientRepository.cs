using MFEC.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MFEC.Domain.Interfaces
{
    public interface IClientRepository : IRepository<Client>, IWriteRepository<Client>
    {
        Client GetByCpf(string cpf);

        Client GetByEmail(string email);

        IEnumerable<Client> GetAllActive();
    }
}
