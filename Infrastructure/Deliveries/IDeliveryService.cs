using AwesomeShopPatterns.API.Application.Models;

namespace AwesomeShopPatterns.API.Infrastructure.Deliveries
{
    public interface IDeliveryService
    {
        public void Delivery(OrderInputModel model);
    }
}