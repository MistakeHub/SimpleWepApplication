using AutoMapper;
using SimpleWebApplication.Domain.Models;

namespace SimpleWebApplication.Models.Mapper
{
    public class MapperConfig:Profile
    {

        public MapperConfig()
        {

            CreateMap<Company, CompanyViewModel>().ForMember(v=>v.Id,c=>c.MapFrom(src=>src.Id))
                .ForMember(v => v.CompanyName, c => c.MapFrom(src => src.Name))
                .ForMember(v => v.City, c => c.MapFrom(src => src.City))
                .ForMember(v => v.State, c => c.MapFrom(src => src.State))
                .ForMember(v => v.Phone, c => c.MapFrom(src => src.Phone));

        }
    }
}
