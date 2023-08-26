using AwesomeShopPatterns.API.Application.Models;

namespace AwesomeShopPatterns.API.Infrastructure.Delivery
{
    public interface IDeliveryService
    {
        public void Delivery(OrderInputModel model);
    }
}