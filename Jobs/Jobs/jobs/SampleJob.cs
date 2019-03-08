using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace Jobs
{
    /// <summary>
    /// A sample job that just prints info on console for demostration purposes.
    /// </summary>
    public class SampleJob : IJob
    {

        private ILog log = LogManager.GetLogger(typeof(SampleJob));
        /// <summary>
        ///  实现定时任务
        /// </summary>
        /// <param name="context"></param>
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                log.Info("SampleJob run..");
            }
            catch (Exception ex)
            {
                log.Info(string.Format("Message:{0}; StackTrace:{1}", ex.Message, ex.StackTrace));
            }
        }
    }
}
