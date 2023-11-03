namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
        private static ILoggerFactory Factory => LoggerFactory.Create(builder => builder.AddDebug().SetMinimumLevel(LogLevel.Debug));

        public static ILogger getLog(Type classType)
        {
            return Factory.CreateLogger(classType);
        }
    }
}