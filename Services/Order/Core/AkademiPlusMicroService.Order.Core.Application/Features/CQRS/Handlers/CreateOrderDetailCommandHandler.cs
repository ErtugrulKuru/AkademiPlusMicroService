using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDetailDtos;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Interfaces;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateOrderDetailCommandHandler : IRequestHandler<CreateOrderDetailCommandRequest, CreateOrderDetailDto>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CreateOrderDetailDto> Handle(CreateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new OrderDetail
            {
                ProductAmount = request.ProductAmount,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductId = request.ProductId,
                OrderingId = request.OrderingId,
            };
            var result = await _repository.CreateAsync(values);
            return _mapper.Map<CreateOrderDetailDto>(result);
        }
    }
}
