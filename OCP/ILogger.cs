namespace ByteBee.OCP
{
    interface ILogger
    {
        void Log(string eintrag);
        void Fehler(string eintrag);
    }
}