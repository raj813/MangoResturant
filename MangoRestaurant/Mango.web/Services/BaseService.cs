using Mango.web.Models;
using Mango.web.Services.IServices;
using Newtonsoft.Json;

namespace Mango.web.Services
{
    public class BaseService : IBaseService
    {
        public Mango.Services.ProductAPI.Models.Dto.ResponseDto responseModel { get; set; }

        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient) 
        {
            this.responseModel = new Mango.Services.ProductAPI.Models.Dto.ResponseDto();
            this.httpClient = httpClient;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MangoAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                // Clear any default Headers available
                client.DefaultRequestHeaders.Clear();

                if (apiRequest.Data != null) 
                {
                    message.Content = new StringContent(JsonConvert.Serializeobect)
                }



            }
            catch (Exception e) 
            {

            }
        }
    }
}
