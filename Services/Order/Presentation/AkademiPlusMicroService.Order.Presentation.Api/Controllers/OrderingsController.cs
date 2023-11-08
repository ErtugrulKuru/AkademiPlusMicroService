using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroService.Order.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public OrderingsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrderingList()
        {
            var value = await _meditor.Send(new GetAllOrderingQueryRequest());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrdering(CreateOrderingCommandRequest createOrderingCommandRequest)
        {
            await _meditor.Send(createOrderingCommandRequest);
            return Ok("Sipariş Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrdering(int id)
        {
            await _meditor.Send(new RemoveOrderingCommandRequest(id));
            return Ok("Sipariş Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderingById(int id)
        {
            var value = await _meditor.Send(new GetOrderingQueryRequest(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrdering(UpdateOrderingCommandRequest updateOrderingCommandRequest)
        {
            await _meditor.Send(updateOrderingCommandRequest);
            return Ok("Güncelleme Başarılı");
        }
    }
}
