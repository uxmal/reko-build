using System;

namespace Windows
{
    public class WindowsEnvironment
    {
        public static WindowsEnvironment Load()
        {
            Console.Write("Loading Windows environment");
            return new WindowsEnvironment();
        }
    }
}
