using System;
using System.IO;

namespace Generate
{
    public class Program
    {
        public static void Main(string [] args)
        {
            using StreamWriter sw = File.CreateText(args[1]);
            sw.WriteLine(@"namespace Windows 
{
    public class MenuSystem
    {
        public string Generate() {
             return ""MenuSystem" + Core.Version.VersionString + @""";
        }

        public string Filename => """ + args[0] + @""";
    }
}"
);
        }
    }
}
