using System.Data;
using AkademiPlusMicroService.Discount.Context;
using AkademiPlusMicroService.Discount.Dtos;
using AkademiPlusMicroService.Shared.Dtos;
using AutoMapper;
using Dapper;
using Microsoft.Data.SqlClient;

namespace AkademiPlusMicroService.Discount.Services
{
    public class DiscountCouponService : IDiscountCouponService
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IDbConnection _dbConnection;
        private readonly DapperContext _dapperContext;

        public DiscountCouponService(IConfiguration configuration, IMapper mapper, DapperContext dapperContext)
        {
            _configuration = configuration;
            _mapper = mapper;
            _dbConnection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
            _dapperContext = dapperContext;
        }

        public async Task<Response<NoContent>> CreateDiscountCoupon(CreateDiscountCouponDtos createDiscountCouponDtos)
        {
            var status = await _dbConnection.ExecuteAsync("insert into DiscountCoupons (UserId,Rate,Code,CreatedDate) values (@UserId,@Rate,@Code,@CreatedDate)",createDiscountCouponDtos);
            var parameters = new DynamicParameters();
            parameters.Add("@UserId", createDiscountCouponDtos.UserId);
            parameters.Add("@Rate", createDiscountCouponDtos.Rate);
            parameters.Add("@Code", createDiscountCouponDtos.Code);
            parameters.Add("@CreatedDate",DateTime.Parse(createDiscountCouponDtos.CreatedDate.ToShortDateString()));

            if (status>0)
            {
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Bir Hata Oluştu", 500);
        }

        public async Task<Response<NoContent>> DeleteDiscountCoupon(int id)
        {
            var status=await _dbConnection.ExecuteAsync("delete from DiscountCoupons where DiscountCouponId=@DiscountCouponId",new{ DiscountCouponId=id });
            if (status > 0)
            {
                return Response<NoContent>.Success(204);
            }
            return Response<NoContent>.Fail("Bir Hata Oluştu", 500);
        }

        public async Task<Response<List<ResultDiscountCouponDtos>>> GetListAll()
        {
            var values = await _dbConnection.QueryAsync<ResultDiscountCouponDtos>("select * from DiscountCoupons");
            return Response<List<ResultDiscountCouponDtos>>.Success(_mapper.Map<List<ResultDiscountCouponDtos>>(values), 200);
        }

        public async Task<Response<NoContent>> UpdateDiscountCoupon(UpdateDiscountCouponDtos updateDiscountCouponDtos)
        {
            string sql =  "update DiscountCoupons set UserId=@UserId,Rate=@Rate,Code=@Code,CreatedDate=@CreatedDate where DiscountCouponId=@DiscountCouponId";

            var parameters = new DynamicParameters();
            parameters.Add("@DiscountCouponId", updateDiscountCouponDtos.DiscountCouponId);
            parameters.Add("@UserId", updateDiscountCouponDtos.UserId);
            parameters.Add("@Rate", updateDiscountCouponDtos.Rate);
            parameters.Add("@Code", updateDiscountCouponDtos.Code);
            parameters.Add("@CreatedDate", DateTime.Parse(updateDiscountCouponDtos.CreatedDate.ToShortDateString()));

            await _dbConnection.ExecuteAsync(sql, parameters);
            return Response<NoContent>.Success(200);
        }
    }
}
