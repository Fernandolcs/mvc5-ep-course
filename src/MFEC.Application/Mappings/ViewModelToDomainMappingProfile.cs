using AutoMapper;
using MFEC.Application.ViewModels;
using MFEC.Domain.Models;

namespace MFEC.Application.Mappings
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientViewModel, Client>();
            CreateMap<AddressViewModel, Address>();
        }
    }
}
