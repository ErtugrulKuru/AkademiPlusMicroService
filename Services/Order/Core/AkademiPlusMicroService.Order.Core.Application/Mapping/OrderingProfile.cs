using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDtos;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;

namespace AkademiPlusMicroService.Order.Core.Application.Mapping
{
    public class OrderingProfile:Profile
    {
        public OrderingProfile()
        {
            CreateMap<ResultOrderingDto, Address>().ReverseMap();
            CreateMap<CreateOrderingDto, Address>().ReverseMap();
            CreateMap<UpdateOrderingDto, Address>().ReverseMap();
        }
    }
}
