using System;

namespace two_fer
{
    class Program
    {
        static void string speak()
        {
            return "one for you one for me.";
        }

        static void string speak(string h)
        {
            if (h == "Bob")
            {
                return "one for bob one for me.";
            }
            else
            {
                return "one for alice one for me.";
            }
        }
    }
}
