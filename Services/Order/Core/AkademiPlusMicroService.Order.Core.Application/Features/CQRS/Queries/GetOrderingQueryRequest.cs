using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDtos;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries
{
    public class GetOrderingQueryRequest:IRequest<ResultOrderingDto>
    {
        public GetOrderingQueryRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
