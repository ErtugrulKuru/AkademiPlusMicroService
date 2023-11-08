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
    public class UpdateOrderDetailCommandHandler : IRequestHandler<UpdateOrderDetailCommandRequest, UpdateOrderDetailDto>
    {
        private readonly IRepository<OrderDetail> _repository;
        private readonly IMapper _mapper;

        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UpdateOrderDetailDto> Handle(UpdateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {

            var value = new OrderDetail
            {
                OrderDetailId = request.OrderDetailId,
                ProductAmount = request.ProductAmount,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductId = request.ProductId,
                OrderingId = request.OrderingId,
            };
            await _repository.UpdateAsync(value);
            return _mapper.Map<UpdateOrderDetailDto>(value);
        }
    }
}
