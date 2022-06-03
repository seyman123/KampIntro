namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            List<ILoggerService> loggers1 = new List<ILoggerService>() { databaseLoggerService, fileLoggerService };
            List<ILoggerService> loggers2 = new List<ILoggerService>() { fileLoggerService, smsLoggerService };

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager, loggers1);
            basvuruManager.BasvuruYap(konutKrediManager, loggers2);

            List<IKrediManager> krediler = new List<IKrediManager>() { tasitKrediManager , ihtiyacKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}