using System;
using Windows;

namespace SysV
{
    public class SysVEnvironment
    {
        private MenuSystem me;

        private SysVEnvironment(MenuSystem me)
        {
            this.me = me;
            this.Name = "SysV";
        }

        public string Name { get; set; }

        public static SysVEnvironment Load()
        {
            var me = new MenuSystem();
            return new SysVEnvironment(me);
        }
    }
}
