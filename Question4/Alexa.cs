using System;
using System.Collections.Generic;
using System.Text;

namespace Question4
{
    public class Alexa
    {
        public string DisplayGreeting   { get; set; }

        public string Talk()
        {
            return DisplayGreeting ?? "hello, i am Alexa";
        }
    }
}
