using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroService.Order.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public OrderDetailsController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        public async Task<IActionResult> GetOrderDetailList()
        {
            var value = await _meditor.Send(new GetAllOrderDetailQueryRequest());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail(CreateOrderDetailCommandRequest createOrderDetailCommandRequest)
        {
            await _meditor.Send(createOrderDetailCommandRequest);
            return Ok("Sipariş Detayları Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrderDetail(int id)
        {
            await _meditor.Send(new RemoveOrderDetailCommandRequest(id));
            return Ok("Sipariş Detayları Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailById(int id)
        {
            var value = await _meditor.Send(new GetOrderDetailQueryRequest(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail(UpdateOrderDetailCommandRequest updateOrderDetailCommandRequest)
        {
            await _meditor.Send(updateOrderDetailCommandRequest);
            return Ok("Güncelleme Başarılı");
        }
    }
}
