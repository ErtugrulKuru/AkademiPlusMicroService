using AkademiPlusMicroService.Discount.Dtos;
using AkademiPlusMicroService.Discount.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AkademiPlusMicroService.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCouponsController : ControllerBase
    {
        private readonly IDiscountCouponService _discountCouponService;

        public DiscountCouponsController(IDiscountCouponService discountCouponService)
        {
            _discountCouponService = discountCouponService;
        }
    
        [HttpPost]
        public async Task<IActionResult> CreateDiscountCoupon(CreateDiscountCouponDtos createDiscountCouponDtos)
        {
            await _discountCouponService.CreateDiscountCoupon(createDiscountCouponDtos);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscountCoupon(int id)
        {
            await _discountCouponService.DeleteDiscountCoupon(id);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> GetListDiscountCoupon()
        {
            var values= await _discountCouponService.GetListAll();
            return Ok(values);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDiscountCoupon(UpdateDiscountCouponDtos updateDiscountCouponDtos)
        {
            await _discountCouponService.UpdateDiscountCoupon(updateDiscountCouponDtos);
            return Ok();
        }



    }
}
