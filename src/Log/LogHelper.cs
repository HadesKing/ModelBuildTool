using log4net;
using log4net.Repository;
using System;
using System.IO;

namespace Log
{
    /// <summary>
    /// 日志帮助类
    /// </summary>
    public class LogHelper
    {

        private static String m_defaultRepositoryName = "NETCoreRepository";
        private static log4net.ILog m_log = LogManager.GetLogger(typeof(LogHelper));
        private static ILoggerRepository m_defaultRepository = LogManager.CreateRepository(m_defaultRepositoryName);

        private const string SError = "Error";
        private const string SFatal = "Fatal";
        private const string SDEBUG = "Debug";
        private const string SWarn = "Warn";
        private const string SInfo = "Info";
        private static log4net.ILog m_errorLogger = null;
        private static log4net.ILog m_debugLogger = null;
        private static log4net.ILog m_infoLogger = null;
        private static log4net.ILog m_fatalLogger = null;
        private static log4net.ILog m_warnLogger = null;

        /// <summary>
        /// 初始加载配置
        /// </summary>
        static LogHelper()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + @"\log4net_config.xml";
            log4net.Config.XmlConfigurator.Configure(m_defaultRepository, new FileInfo(path));
            m_errorLogger = LogManager.GetLogger(m_defaultRepositoryName, SError);
            m_debugLogger = LogManager.GetLogger(m_defaultRepositoryName, SDEBUG);
            m_infoLogger = LogManager.GetLogger(m_defaultRepositoryName, SInfo);
            m_fatalLogger = LogManager.GetLogger(m_defaultRepositoryName, SFatal);
            m_warnLogger = LogManager.GetLogger(m_defaultRepositoryName, SWarn);
        }

        /// <summary>
        /// DEBUG日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        /// <param name="exception">错误信息</param>
        public static void Debug(String argMessage, Exception exception = null)
        {
            m_debugLogger.Debug(argMessage, exception);
        }


        /// <summary>
        /// 报错日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        public static void Error(String argMessage)
        {
            m_errorLogger.ErrorFormat(argMessage);
        }

        /// <summary>
        /// 报错日志
        /// </summary>
        /// <param name="argCustomErrorMsg">自定义错误信息</param>
        /// <param name="exception">错误信息</param>
        public static void Error(String argCustomErrorMsg, Exception exception)
        {
            m_errorLogger.Error(argCustomErrorMsg, exception);
        }

        /// <summary>
        /// 一般信息日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        public static void Info(String argMessage)
        {
            m_infoLogger.Info(argMessage);
        }

        /// <summary>
        /// 致命错误日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        /// <param name="exception">错误信息</param>
        public static void Fatal(String argMessage, Exception exception = null)
        {
            m_fatalLogger.Fatal(argMessage, exception);
        }

        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        /// <param name="exception">错误信息</param>
        public static void Warn(String argMessage, Exception exception = null)
        {
            m_warnLogger.Warn(argMessage, exception);
        }


    }
}

