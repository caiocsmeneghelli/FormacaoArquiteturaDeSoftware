using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShopPatterns.API.Application.Models;

namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public class PaymentSlipService : IPaymentService
    {
        public PaymentSlipModel Process(OrderInputModel model)
        {
            var builder = new PaymentSlipBuilder();
            
            return builder.Start()
                .WithPayer(new Payer("Payer", "223.234.123-00", "21St."))
                .WithReceiver(new Receiver("Receiver", "233.114.242-00", "22St."))
                .WithDates(DateTime.Now, DateTime.Now.AddDays(3))
                .WithAmount(23442.2m)
                .WithNumbers("33324.332334.22356.223", "8859")
                .Build();

        }
    }
}