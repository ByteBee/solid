namespace ByteBee.OCP
{
    class System
    {
        private ILogger _logger;

        public System(ILogger logger)
        {
            _logger = logger;
        }

        public void Logik()
        {
            _logger.Log("Einfache Log-Nachricht");
            _logger.Fehler("Fehlernachricht");
        }
    }
}