using AutoMapper;
using MFEC.Application.Interfaces;
using MFEC.Application.ViewModels;
using MFEC.Domain.Interfaces;
using MFEC.Domain.Models;
using MFEC.Infra.Data.Repositories;
using System;
using System.Collections.Generic;

namespace MFEC.Application.Services
{
    public class ClientAppService : IClientAppService
    {
        private readonly IClientRepository _clientRepository;

        public ClientAppService()
        {
            _clientRepository = new ClientRepository();
        }

        public IEnumerable<ClientViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<ClientViewModel>>(_clientRepository.GetAll());
        }

        public IEnumerable<ClientViewModel> GetAllActive()
        {
            return Mapper.Map<IEnumerable<ClientViewModel>>(_clientRepository.GetAllActive());
        }

        public ClientViewModel GetByCpf(string cpf)
        {
            return Mapper.Map<ClientViewModel>(_clientRepository.GetByCpf(cpf));
        }

        public ClientViewModel GetByEmail(string email)
        {
            return Mapper.Map<ClientViewModel>(_clientRepository.GetByEmail(email));
        }

        public ClientViewModel GetById(Guid id)
        {
            return Mapper.Map<ClientViewModel>(_clientRepository.GetById(id));
        }

        public ClientAddressViewModel Insert(ClientAddressViewModel clientAddressViewModel)
        {
            var client = Mapper.Map<Client>(clientAddressViewModel.Client);
            var address = Mapper.Map<Address>(clientAddressViewModel.Client);
            client.Activate();
            client.AddAddress(address);
            _clientRepository.Insert(client);
            return clientAddressViewModel;
        }

        public ClientViewModel Update(ClientViewModel clientViewModel)
        {
            var client = Mapper.Map<Client>(clientViewModel);
            _clientRepository.Update(client);
            return clientViewModel;
        }

        public void Remove(Guid id)
        {
            _clientRepository.Remove(id);
        }

        public void Dispose()
        {
            _clientRepository.Dispose();
        }
    }
}
