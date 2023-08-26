using AwesomeShopPatterns.API.Core.Enums;
using AwesomeShopPatterns.API.Infrastructure.Deliveries;
using AwesomeShopPatterns.API.Infrastructure.Payments;

namespace AwesomeShopPatterns.API.Infrastructure.Order
{
    public class InternationalOrderAbstractionFactory : IOrderAbstractFactory
    {
        private readonly InternationalDeliveryService _internationalDeliveryService;
        private readonly CreditCardService _creditCardService;

        public InternationalOrderAbstractionFactory(InternationalDeliveryService internationalDeliveryService, 
            CreditCardService creditCardService)
        {
            _internationalDeliveryService = internationalDeliveryService;
            _creditCardService = creditCardService;
        }

        public IDeliveryService GetDeliveryService()
        {
            return _internationalDeliveryService;
        }

        public IPaymentService GetPaymentService(PaymentMethod paymentMethod)
        {
            return _creditCardService;
        }
    }
}