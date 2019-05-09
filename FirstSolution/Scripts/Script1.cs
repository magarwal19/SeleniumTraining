using System;

namespace Scripts
{
    public class Script1
    {
        public bool scriptFirst(string message)
        {
            if (message.Contains("test"))
                return true;
            else
                return false;
        }
    }
}
