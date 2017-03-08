using System.Net;
using Newtonsoft.Json;
using Twilio.Clients;
using UnitTestProject1;

namespace Twilio.Mocks
{
    public static class MockResponse
    {
        public static ITwilioRestClient Setup(HttpStatusCode statusCode, object response)
        {
            var json = JsonConvert.SerializeObject(response);
            var testHttpClient = new FakeTwilioHttpClient(statusCode, json);
            var testClient = new TwilioRestClient("ACxxx", "test",
                httpClient: testHttpClient);
            TwilioClient.SetRestClient(testClient);
            return testClient;
        }
    }
}
