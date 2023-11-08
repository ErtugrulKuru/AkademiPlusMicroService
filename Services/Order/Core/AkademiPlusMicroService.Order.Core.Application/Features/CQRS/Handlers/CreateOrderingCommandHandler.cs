using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.OrderDtos;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Interfaces;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateOrderingCommandHandler:IRequestHandler<CreateOrderingCommandRequest, CreateOrderingDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public CreateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CreateOrderingDto> Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Ordering
            {
                OrderDate = request.OrderDate,
                TotalPrice = request.TotalPrice,
                UserId = request.UserId,
            };
            var result= await _repository.CreateAsync(values);
            return _mapper.Map<CreateOrderingDto>(result);
        }
    }
}
