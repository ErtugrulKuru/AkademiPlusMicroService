using AkademiPlusMicroService.Bussiness.Abstract;
using AkademiPlusMicroService.EntityLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroService.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailSController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;

        public CargoDetailSController(ICargoDetailService cargoDetailService)
        {
            _cargoDetailService = cargoDetailService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllCargoDetail()
        {
            var value= await _cargoDetailService.TGetAllAsync();
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCargoDetail(CargoDetail cargoDetail)
        {
            await _cargoDetailService.TCreateAsync(cargoDetail);
            return Ok("Başarıyla Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCargoDetail(CargoDetail cargoDetail)
        {
            await _cargoDetailService.TUpdateAsync(cargoDetail);
            return Ok("Başarıyla Güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCargoDetail(int id)
        {
            var value = await _cargoDetailService.TGetAsync(id);
            await _cargoDetailService.TDeleteAsync(value);
            return Ok("Başarıyla Silindi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCargoDetails(int id)
        {
            var value = await _cargoDetailService.TGetAsync(id);
            return Ok(value);
        }
    }
}
