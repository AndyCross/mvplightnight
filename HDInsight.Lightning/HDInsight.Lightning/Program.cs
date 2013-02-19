using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Hadoop.MapReduce;

namespace HDInsight.Lightning
{
    class Program
    {
        static void Main(string[] args)
        {
            HadoopJobExecutor.ExecuteJob<Jobs.MyJob>(args);
        }
    }
}
