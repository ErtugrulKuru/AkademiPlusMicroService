using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Commands;
using AkademiPlusMicroService.Order.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroService.Order.Presentation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _meditor;

        public AddressesController(IMediator meditor)
        {
            _meditor = meditor;
        }
        [HttpGet]
        public async Task<IActionResult> GetAddressList()
        {
            var value = await _meditor.Send(new GetAllAddressQueryRequest());
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAddress(CreateAddressCommandRequest createAddressCommandRequest)
        {
            await _meditor.Send(createAddressCommandRequest);
            return Ok("Adres Eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            await _meditor.Send(new RemoveAddressCommandRequest(id));
            return Ok("Adres Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(int id)
        {
            var value = await _meditor.Send(new GetAddressQueryRequest(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateAddress(UpdateAddressCommandRequest updateAddressCommandRequest)
        {
            await _meditor.Send(updateAddressCommandRequest);
            return Ok("Güncelleme Başarılı");
        }
    }
}
