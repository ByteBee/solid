using System;

namespace ByteBee.OCP
{
    class GuiLogger : ILogger
    {
        public void Log(string eintrag)
        {
            Console.WriteLine("LOG: " + eintrag + " (GUI)");

        }

        public void Fehler(string eintrag)
        {
            Console.WriteLine("ERR: " + eintrag + " (GUI)");
        }
    }
}