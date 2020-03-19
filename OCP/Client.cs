namespace ByteBee.OCP
{
    class Client
    {
        static void Main(string[] args)
        {
            var alleLogger = new ILogger[]
            {
                new GuiLogger(),
                new DateiLogger(),
                new FehlerEmailLogger(),
            };
            var log = new VerbundsLogger(alleLogger);
            var s = new System(log);

            s.Logik();
        }
    }
}