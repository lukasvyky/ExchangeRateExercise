using ExchangeRateApp.Models.DTOs;
using System.Globalization;
using System.Net.Http.Json;

namespace ExchangeRateApp.APIs
{
    public class CNBExchangeData(IHttpClientFactory factory) : IExchangeData
    {
        private HttpClient HttpClient { get; set; } = factory.CreateClient("httpClient");

        public async Task<IEnumerable<ExchangeRateDTO>> FetchExchangeDataAsync()
        {

            string dateNow = DateTimeOffset.UtcNow.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            var httpResponse = await HttpClient.GetAsync($"/cnbapi/exrates/daily?date={dateNow}&lang=EN");
            var responseContent = await httpResponse.Content.ReadFromJsonAsync<CNBWrapperDTO>();

            return responseContent.;
        }
    }
}
