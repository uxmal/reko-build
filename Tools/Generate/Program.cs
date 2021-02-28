using System;
using System.IO;
using System.Linq;

namespace Generate
{
    public class Program
    {
        public static void Main(string [] args)
        {
            var line = File.ReadLines(args[0]).FirstOrDefault() ?? "<Empty>";
            using StreamWriter sw = File.CreateText(args[1]);
            sw.WriteLine(@"namespace Windows 
{
    public class MenuSystem
    {
        public string Generate() {
             return ""MenuSystem" + Core.Version.VersionString + @""";
        }

        public string TestZone => """ + line + @""";

        public string Filename => """ + args[0] + @""";
    }
}"
);
        }
    }
}
