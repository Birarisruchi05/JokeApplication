using JokeApplication.Web.Models;
using Newtonsoft.Json;
using System.Text;

namespace JokeApplication.Web.Repository
{
    public class BaseService
    {
        public ResponseDto responseModel { get; set; }

        public IHttpClientFactory httpClient { get; set; }

        public BaseService(IHttpClientFactory httpClient)
        {
            this.responseModel = new ResponseDto();
            this.httpClient = httpClient;
        }
        public async Task<T> SendAsync<T>(ApiRequest apiRequest)
        {
            try
            {
                var client = httpClient.CreateClient("MangoAPI");
                HttpRequestMessage message = new HttpRequestMessage();
                message.Headers.Add("Accept", "application/json");
                message.RequestUri = new Uri(apiRequest.Url);
                client.DefaultRequestHeaders.Clear();
                if (apiRequest.Data != null)
                {
                    message.Content = new StringContent(JsonConvert.SerializeObject(apiRequest.Data), Encoding.UTF8, "application/json");
                }
                HttpResponseMessage apiResponse = null;
                switch (apiRequest.ApiType)
                {
                    case SD.ApiType.POST:
                        message.Method = HttpMethod.Post;
                        break;
                    case SD.ApiType.PUT:
                        message.Method = HttpMethod.Put;
                        break;
                    case SD.ApiType.DELETE:
                        message.Method = HttpMethod.Delete;
                        break;
                    default:
                        message.Method = HttpMethod.Get;
                        break;

                }
                apiResponse = await client.SendAsync(message);

                var apiContent = await apiResponse.Content.ReadAsStringAsync();
                var apiResponseDeto = JsonConvert.DeserializeObject<T>(apiContent);
                return apiResponseDeto;

            }
            catch (Exception ex)
            {
                var responsedto = new ResponseDto
                {
                    Susccess = false
                };
                var res = JsonConvert.SerializeObject(responsedto);
                var apiresp = JsonConvert.DeserializeObject<T>(res);
                return apiresp;

            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
