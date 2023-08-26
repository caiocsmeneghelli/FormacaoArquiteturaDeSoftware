using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopPatterns.API.Application.Models;
using AwesomeShopPatterns.API.Core.Enums;
using AwesomeShopPatterns.API.Infrastructure.Order;
using AwesomeShopPatterns.API.Infrastructure.Payments;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeShopPatterns.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;
        public OrdersController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post(OrderInputModel model,
            [FromServices] InternationalOrderAbstractionFactory internationalOrderAbstractionFactory,
            [FromServices] NationalOrderAbstractionFactory nationalOrderAbstractionFactory)
        {
            IOrderAbstractFactory abstractFactory;
            if (model.IsInternational != null && model.IsInternational.Value)
            {
                abstractFactory = internationalOrderAbstractionFactory;
            }
            else
            {
                abstractFactory = nationalOrderAbstractionFactory;
            }

            var paymentResult =  abstractFactory
                .GetPaymentService(model.PaymentInfo.PaymentMethod)
                .Process(model);

            return NoContent();
        }
    }
}