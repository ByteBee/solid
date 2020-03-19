using System;

namespace ByteBee.OCP
{
    class DateiLogger : ILogger
    {
        ILogNachrichtFormatierung _formatierung = new NachrichtMitDatum();

        public void Log(string eintrag)
        {
            string formatierteNachricht = _formatierung.Formatiere("LOG: " + eintrag + " (Datei)");
            Console.WriteLine(formatierteNachricht);
        }

        public void Fehler(string eintrag)
        {
            string formatierteNachricht = _formatierung.Formatiere("ERR: " + eintrag + " (Datei)");
            Console.WriteLine(formatierteNachricht);
        }
    }
}