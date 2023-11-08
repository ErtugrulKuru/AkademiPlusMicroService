using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Interfaces;
using AkademiPlusMicroService.Order.Core.Domain.Entities;
using MediatR;

namespace AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Handlers
{
    public class RemoveAddressCommandHandler : IRequestHandler<RemoveAddressCommandRequest>
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var value= await _repository.GetByIdAsync(request.Id);
            _repository.DeleteAsync(value);
        }
    }
}
