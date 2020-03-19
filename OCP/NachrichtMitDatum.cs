using System;

namespace ByteBee.OCP
{
    class NachrichtMitDatum : ILogNachrichtFormatierung
    {
        public string Formatiere(string nachricht)
        {
            return DateTime.UtcNow.ToString("s") + nachricht;
        }
    }
}