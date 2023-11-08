using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.AdressDtos;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Interfaces;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Handlers
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressDto>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<CreateAddressDto> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Address 
            {
                City = request.City,
                Detail = request.Detail,
                District = request.District,
                UserId = request.UserId,
            };
            var result=await _repository.CreateAsync(values);

            return _mapper.Map<CreateAddressDto>(result);
        }
    }
}
