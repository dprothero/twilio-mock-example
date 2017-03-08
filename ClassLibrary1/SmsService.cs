using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace ClassLibrary1
{
    public class SmsService
    {
        public SmsService()
        {
            TwilioClient.Init(Environment.GetEnvironmentVariable("TWILIO_ACCOUNT_SID"),
                Environment.GetEnvironmentVariable("TWILIO_AUTH_TOKEN"));
        }

        public MessageResource SendMessage(string to, string body)
        {
            var msg = MessageResource.Create(new PhoneNumber(to),
                from: new PhoneNumber("+12098675309"), body: body);

            return msg;
        }
    }
}
