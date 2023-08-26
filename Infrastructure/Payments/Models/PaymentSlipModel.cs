namespace AwesomeShopPatterns.API.Infrastructure.Payments
{
    public class PaymentSlipModel
    {
        public PaymentSlipModel()
        {
            
        }
        public PaymentSlipModel(string barCode, string ourNumber,
            DateTime expiresAt, DateTime processedAt, 
            decimal documentAmount, Payer payer, Receiver receiver)
        {
            BarCode = barCode;
            OurNumber = ourNumber;
            ExpiresAt = expiresAt;
            ProcessedAt = processedAt;
            DocumentAmount = documentAmount;
            Payer = payer;
            Receiver = receiver;
        }

        public string BarCode { get; set; }
        public string OurNumber { get; set; }
        public DateTime ExpiresAt { get; set; }
        public DateTime ProcessedAt { get; set; }
        public decimal DocumentAmount { get; set; }
        public Payer Payer { get; set; }
        public Receiver Receiver { get; set; }
    }

    public class Payer{
        public Payer(string name, string document, string address)
        {
            Name = name;
            Document = document;
            Address = address;
        }

        public string Name {get;set;}
        public string Document {get;set;}
        public string Address { get; set; }
    }

    public class Receiver
    {
        public Receiver(string name, string document, string address)
        {
            Name = name;
            Document = document;
            Address = address;
        }

        public string Name {get;set;}
        public string Document {get;set;}
        public string Address { get; set; }
    }
}