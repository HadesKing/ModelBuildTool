using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Log
{
    /// <summary>
    /// 日志接口
    /// </summary>
    public interface ILog
    {


        /// <summary>
        /// 一般信息日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        void Info(String argMessage);

        /// <summary>
        /// DEBUG日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        /// <param name="exception">错误信息</param>
        void Debug(String argMessage, Exception argException = null);

        /// <summary>
        /// 报错日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        void Error(String argMessage);

        /// <summary>
        /// 报错日志
        /// </summary>
        /// <param name="argCustomErrorMsg">自定义错误信息</param>
        /// <param name="exception">错误信息</param>
        void Error(String argMessage, Exception argException);

        /// <summary>
        /// 致命错误日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        /// <param name="exception">错误信息</param>
        void Fatal(String argMessage, Exception exception = null);

        /// <summary>
        /// 警告日志
        /// </summary>
        /// <param name="argMessage">信息，可自定义</param>
        /// <param name="exception">错误信息</param>
        void Warn(String argMessage, Exception argException = null);

    }
}