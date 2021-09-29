﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueTrackerInfrastructure
{

    public class LogDetail
    {
        public string Message { get; set; }
        public DateTime LogTime { get; set; }

        /// <summary>
        /// Overriding string method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Message} at {LogTime}";
        }
    }

    /// <summary>
    /// LogHelper class to Log Information
    /// </summary>
    public class LogHelper
    {

        private static List<LogDetail> _logs = new List<LogDetail>();

        /// <summary>
        /// Log Updated event
        /// </summary>
        public event EventHandler<List<LogDetail>> LogUpdated;

       /// <summary>
       /// Method to log information
       /// </summary>
       /// <param name="msg"></param>
        public void LogInfo(string msg)
        {
            _logs.Add(new LogDetail { Message = msg, LogTime = DateTime.Now });
            this.LogUpdated(this, _logs);
        }

        /// <summary>
        /// Method to get all log information
        /// </summary>
        /// <returns></returns>
        public List<LogDetail> GetAllLogInfo()
        {
            return _logs;
        }
    }
}
