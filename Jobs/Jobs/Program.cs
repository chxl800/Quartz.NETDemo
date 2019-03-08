using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Jobs
{
    public static class Program
    {
        /// <summary>
        /// Main.
        /// </summary>
        public static void Main()
        {
            // change from service account's dir to more logical one
            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            HostFactory.Run(x =>
            {
                x.RunAsLocalSystem();
                x.SetDescription("Quartz_Description");
                x.SetDisplayName("Quartz_DisplayName");
                x.SetServiceName("Quartz_ServiceName");
                x.Service(factory =>
                {
                    QuartzServer server = QuartzServerFactory.CreateServer();
                    server.Initialize();
                    return server;
                });
            });

            /*
             添加作业： 像SampleJob: IJob， 继承IJob； 然后在quartz_jobs.xml文件中配置Job和trigger
             */
        }
    }
}
