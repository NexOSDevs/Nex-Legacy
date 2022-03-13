using System;
using System.Collections.Generic;
using System.Text;
using Nex;

namespace Nex.System.Commands
{
    class PcInfo
    {
        public static string GetAmountRAM()
        {
            return Cosmos.Core.CPU.GetAmountOfRAM() + "MB";
        }
        public static void PCInfo(string user)
        {
            string RAM = GetAmountRAM();
            Console.WriteLine("PC Name: " + "slushy-test");
            Console.WriteLine("PC Name: " + "slushy-test");
            Console.WriteLine("Total Ram: " + RAM);
            Cosmos.HAL.Global.PIT.Wait(20000);
            Console.ForegroundColor = ConsoleColor.White;
            Markup.Type(user);
        }
    }
}
