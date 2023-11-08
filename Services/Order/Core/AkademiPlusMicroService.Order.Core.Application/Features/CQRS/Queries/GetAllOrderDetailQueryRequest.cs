using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDtos;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries
{
    public class GetAllOrderDetailQueryRequest:IRequest<List<ResultOrderDetailDto>>
    {
    }
}
