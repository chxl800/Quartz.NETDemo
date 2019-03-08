using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobs
{
    public class QuartzServerFactory
    {
        /// <summary>
        /// Creates a new instance of an Quartz.NET server core.
        /// </summary>
        /// <returns></returns>
        public static QuartzServer CreateServer()
        {
            string typeName = typeof(QuartzServer).AssemblyQualifiedName;
            Type t = Type.GetType(typeName, true);
            //logger.Debug("Creating new instance of server type '" + typeName + "'");
            QuartzServer retValue = (QuartzServer)Activator.CreateInstance(t);
            //logger.Debug("Instance successfully created");
            return retValue;
        }
    }
}
