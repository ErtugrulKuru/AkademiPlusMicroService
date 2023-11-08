using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.AdressDtos;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;

namespace AkademiPlusMicroService.Order.Core.Application.Mapping
{
    public class OrderDetailProfile:Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<ResultOrderDetailDto, Address>().ReverseMap();
            CreateMap<CreateOrderDetailDto, Address>().ReverseMap();
            CreateMap<UpdateOrderDetailDto, Address>().ReverseMap();
        }
    }
}

