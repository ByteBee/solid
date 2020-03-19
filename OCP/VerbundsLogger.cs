namespace ByteBee.OCP
{
    class VerbundsLogger : ILogger
    {
        private readonly ILogger[] _loggers;

        public VerbundsLogger(ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void Log(string eintrag)
        {
            foreach (ILogger logger in _loggers)
            {
                logger.Log(eintrag);
            }
        }

        public void Fehler(string eintrag)
        {
            foreach (ILogger logger in _loggers)
            {
                logger.Fehler(eintrag);
            }
        }
    }
}