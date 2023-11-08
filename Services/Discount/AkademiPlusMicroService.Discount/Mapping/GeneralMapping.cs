using AkademiPlusMicroService.Discount.Dtos;
using AkademiPlusMicroService.Discount.Models;
using AutoMapper;

namespace AkademiPlusMicroService.Discount.Mapping
{
    public class GeneralMapping:Profile
    {
       public GeneralMapping() 
        { 
            CreateMap<DiscountCoupon,ResultDiscountCouponDtos>().ReverseMap();
            CreateMap<DiscountCoupon,CreateDiscountCouponDtos>().ReverseMap();
            CreateMap<DiscountCoupon,UpdateDiscountCouponDtos>().ReverseMap();
        }

    }
}
