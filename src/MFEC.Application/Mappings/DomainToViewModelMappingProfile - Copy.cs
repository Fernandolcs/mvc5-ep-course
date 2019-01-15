using AutoMapper;
using MFEC.Application.ViewModels;
using MFEC.Domain.Models;

namespace MFEC.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Client, ClientViewModel>();
            CreateMap<Address, AddressViewModel>();
        }
    }
}
