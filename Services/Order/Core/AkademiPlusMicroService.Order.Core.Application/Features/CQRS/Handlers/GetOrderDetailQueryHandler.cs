using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries;
using AkademiPlusMicroService.Order.Core.Application.Interfaces;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQueryRequest, ResultOrderDetailDto>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultOrderDetailDto> Handle(GetOrderDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderDetailDto>(value);
        }
    }
}
