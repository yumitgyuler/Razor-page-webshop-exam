using System.Net.Http;
using System.Net.Http.Headers;

namespace SinusSkateboards.DataAccess.Context
{
    public class ApiHelper
    {
        public static HttpClient ApiContext { get; set; }

        public static void InitializeClinet()
        {
            ApiContext = new HttpClient();

            ApiContext.DefaultRequestHeaders.Accept.Clear();
            ApiContext.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}