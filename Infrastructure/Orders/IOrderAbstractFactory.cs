using AwesomeShopPatterns.API.Core.Enums;
using AwesomeShopPatterns.API.Infrastructure.Deliveries;
using AwesomeShopPatterns.API.Infrastructure.Payments;

namespace AwesomeShopPatterns.API.Infrastructure.Order
{
    public interface IOrderAbstractFactory
    {
        IPaymentService GetPaymentService(PaymentMethod paymentMethod);
        IDeliveryService GetDeliveryService();
    }
}