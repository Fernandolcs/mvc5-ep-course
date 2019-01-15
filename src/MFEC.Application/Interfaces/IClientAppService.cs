using MFEC.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace MFEC.Application.Interfaces
{
    public interface IClientAppService : IDisposable
    {
        ClientAddressViewModel Insert(ClientAddressViewModel clientAddressViewModel);

        ClientViewModel GetById(Guid id);

        IEnumerable<ClientViewModel> GetAll();

        IEnumerable<ClientViewModel> GetAllActive();

        ClientViewModel GetByCpf(string CPF);

        ClientViewModel GetByEmail(string email);

        ClientViewModel Update(ClientViewModel clientViewModel);

        void Remove(Guid id);
    }
}
