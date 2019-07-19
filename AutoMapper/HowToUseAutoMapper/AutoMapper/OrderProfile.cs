using AutoMapper;

namespace HowToUseAutoMapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(dto => dto.OrderId, conf => conf.MapFrom(src => src.Id))
                .ForMember(dto =>dto.ItemId, conf => conf.MapFrom(src => src.Item.Id))
                .ForMember(dto => dto.ItemName, conf => conf.MapFrom(src => src.Item.Name))
                .ForMember(dto => dto.ItemCost, conf => conf.MapFrom(source => source.Item.Cost));
             
        }
    }
}
