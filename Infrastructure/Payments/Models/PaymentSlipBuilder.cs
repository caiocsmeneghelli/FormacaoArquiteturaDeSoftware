namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public class PaymentSlipBuilder
    {
        private PaymentSlipModel _paymentSlipModel;
        public PaymentSlipBuilder() { }
        public PaymentSlipBuilder Start()
        {
            _paymentSlipModel = new PaymentSlipModel();
            return this;
        }
        public PaymentSlipBuilder WithReceiver(Receiver receiver){
            _paymentSlipModel.Receiver = receiver;
            return this;
        }
        public PaymentSlipBuilder WithPayer(Payer payer){
            _paymentSlipModel.Payer = payer;
            return this;
        }
        public PaymentSlipBuilder WithDates(DateTime processAt, DateTime expiresAt)
        {
            _paymentSlipModel.ProcessedAt = processAt;
            _paymentSlipModel.ExpiresAt = expiresAt;
            return this;
        }
        public PaymentSlipBuilder WithNumbers(string barCode, string ourNumber)
        {
            _paymentSlipModel.BarCode = barCode;
            _paymentSlipModel.OurNumber = ourNumber;
            return this;
        }
        public PaymentSlipBuilder WithAmount(decimal amount)
        {
            _paymentSlipModel.DocumentAmount = amount;
            return this;
        }
        public PaymentSlipModel Build()
        {
            return _paymentSlipModel;
        }
    }
}