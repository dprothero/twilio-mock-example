using System.Net;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twilio.Mocks;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var service = new SmsService();
            
            var testToNumber = "+12095551212";
            var testSid = "SM123";
            var testBody = "Yo";

            // Make sure anything than calls Twilio.Init (like the above
            // service constructor) is called before setting up a mock response.
            MockResponse.Setup(HttpStatusCode.Accepted,
                new
                {
                    Sid = testSid,
                    To = testToNumber,
                    From = "+12098675309",
                    Body = testBody
                });

            var msg = service.SendMessage(testToNumber, testBody);

            Assert.AreEqual(testSid, msg.Sid);
            Assert.AreEqual(testBody, msg.Body);
        }
    }
}
