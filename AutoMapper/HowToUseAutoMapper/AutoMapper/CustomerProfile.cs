using AutoMapper;

namespace HowToUseAutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Name, m=>m.MapFrom(source=>source.Name()));
        }
    }
}
