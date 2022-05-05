using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    public static class Extension
    {
        public static void Configure(this Alexa alexa, Action<AlexaOptions> setGreeting)
        {
            //setGreeting = createGreeting;
            AlexaOptions alexaOptions = new AlexaOptions();
            //var test = setGreeting.GetObjectData;
            setGreeting.Invoke(alexaOptions);

            alexa.DisplayGreeting = createGreeting(alexaOptions);
        }

        private static string createGreeting(AlexaOptions options)
        {
            return options.GreetingMessage.Replace("{OwnerName}", options.OwnerName);
        }
    }
}
