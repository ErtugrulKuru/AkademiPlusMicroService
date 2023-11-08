using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.AdressDtos;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands
{
    public class CreateAddressCommandRequest:IRequest<CreateAddressDto>
    {
        public string UserId { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Detail { get; set; }
    }
}
