using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.AdressDtos;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;

namespace AkademiPlusMicroService.Order.Core.Application.Mapping
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
                CreateMap<ResultAddressDto,Address>().ReverseMap();
                CreateMap<CreateAddressDto,Address>().ReverseMap();
                CreateMap<UpdateAddressDto,Address>().ReverseMap();
        }
    }
}
