using AkademiPlusMicroService.Services.Payment.Dal;
using Microsoft.EntityFrameworkCore;

namespace AkademiPlusMicroService.Services.Payment.Context
{
    public class PaymentContext:DbContext
    { 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost,1433; database=PaymentDb;user=sa;password=123456Aa*");
        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
