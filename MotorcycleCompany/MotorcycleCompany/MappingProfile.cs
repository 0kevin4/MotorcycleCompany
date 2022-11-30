using AutoMapper;
using Entities.Models;
using Shared.DataTransferObject;

namespace MotorcycleCompany
{
    public class MappingProfile : Profile
    {
        public MappingProfile ()
        {
            CreateMap<Agency, AgencyDto>();
            CreateMap<City, CityDto>();
            CreateMap<Client, ClientDto>();
            CreateMap<Garage, GarageDto>();
            CreateMap<Motorcycle, MotorcycleDto>();
            CreateMap<Phones, PhonesDto>();
            CreateMap<Rent, RentDto>();

        }
    }
}
