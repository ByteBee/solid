using System;

namespace ByteBee.OCP
{
    class FehlerEmailLogger : ILogger
    {
        ILogNachrichtFormatierung _formatierung = new NachrichtMitDatum();

        public void Log(string eintrag)
        {
        }

        public void Fehler(string eintrag)
        {
            string formatierteNachricht = _formatierung.Formatiere("Email an chef@acme.org: " + eintrag);
            Console.WriteLine(formatierteNachricht);
        }
    }
}