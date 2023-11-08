namespace AkademiPlusMicroService.Services.Payment.Dal
{
    public class PaymentDetail
    {
        public int PaymentDetailId { get; set; }
        public string CardNumber { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }
        public string PaymentType { get; set; }
    }
}
