using System.Net;
using System.Threading.Tasks;
using Twilio.Http;

namespace UnitTestProject1
{
    public class FakeTwilioHttpClient : HttpClient
    {
        private readonly HttpStatusCode _statusCode;
        private readonly string _responseJson;

        public FakeTwilioHttpClient(HttpStatusCode statusCode, string responseJson)
        {
            _statusCode = statusCode;
            _responseJson = responseJson;
        }

        public override Response MakeRequest(Request request)
        {
            var response = new Response(_statusCode, _responseJson);
            return response;
        }

        public override Task<Response> MakeRequestAysnc(Request request)
        {
            return Task.FromResult(this.MakeRequest(request));
        }
    }
}
