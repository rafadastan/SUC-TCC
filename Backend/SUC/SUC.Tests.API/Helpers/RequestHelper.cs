using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace SUC.Tests.API.Helpers
{
    public class RequestHelper
    {
        public static StringContent Create(object request)
        {
            return new StringContent(JsonConvert.SerializeObject(request),
                Encoding.UTF8, "application/json");
        }
    }
}
