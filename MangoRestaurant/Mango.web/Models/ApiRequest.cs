using static Mango.web.SD;

namespace Mango.web.Models
{
    public class ApiRequest
    {
        public ApiType ApiType { get; set; } = ApiType.GET;

        public string Url { get; set; }

        public string Data { get; set; }

        public string AccessToken { get; set; }

    }
}
