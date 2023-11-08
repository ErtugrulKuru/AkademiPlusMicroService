using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.AdressDtos;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAllAddressQueryRequest: IRequest<List<ResultAddressDto>>
    {

    }
}
