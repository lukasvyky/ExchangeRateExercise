using System.Text.Json.Serialization;

namespace ExchangeRateApp.Models.DTOs
{
    public class CNBWrapperDTO
    {
        public required CNBRateResponseDTO[] Rates { get; set; }
    }
}
