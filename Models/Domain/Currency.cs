namespace ExchangeRateApp.Models.Domain
{
    public class Currency(string code)
    {
        public string Code { get; set; } = code;

        public override string ToString()
        {
            return Code;
        }
    }
}
