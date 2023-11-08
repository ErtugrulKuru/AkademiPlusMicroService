using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Dtos.AdressDtos;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries;
using AkademiPlusMicroService.Order.Core.Application.Interfaces;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using AutoMapper;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetAddressQueryHandler : IRequestHandler<GetAddressQueryRequest, ResultAddressDto>
    {
        private readonly IRepository<Address> _repository;
        private readonly IMapper _mapper;

        public GetAddressQueryHandler(IRepository<Address> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultAddressDto> Handle(GetAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultAddressDto>(value);
        }
    }
}
