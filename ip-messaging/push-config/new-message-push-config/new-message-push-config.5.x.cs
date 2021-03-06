// Download the twilio-csharp library from twilio.com/docs/libraries/csharp
using System;
using Twilio;
using Twilio.Rest.Chat.V2;

class Example
{
    static void Main (string[] args)
    {
        // Find your Account Sid at https://www.twilio.com/console/account/settings
        const string accountSid = "ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
        // Create an API Key and Secret at https://www.twilio.com/console/chat/dev-tools/api-keys
        const string authToken = "your_auth_token";
        // Your Chat Service SID from https://www.twilio.com/console/chat/services
        const string serviceSid = "ISXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

        // Authenticate with Twilio
        TwilioClient.Init(accountSid, authToken);

        // Update the service webhooks
        const string newMessageTemplate = "A New message in ${CHANNEL} from " +
                "${USER}: ${MESSAGE}";
        var service = ServiceResource.Update(serviceSid,
            notificationsNewMessageEnabled: true,
            notificationsNewMessageTemplate: newMessageTemplate,
            notificationsNewMessageSound: "default");

        Console.WriteLine(service);
    }
}
