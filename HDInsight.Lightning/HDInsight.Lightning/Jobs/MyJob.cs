using HDInsight.Lightning.Mappers;
using HDInsight.Lightning.Reducers;
using Microsoft.Hadoop.MapReduce;

namespace HDInsight.Lightning.Jobs
{
    public class MyJob : HadoopJob<MyMapper, MyReducer>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            var configuration = new HadoopJobConfiguration
            {
                InputPath = context.Arguments[0],
                OutputFolder = context.Arguments[1]
            };

            configuration.AdditionalGenericArguments.Add("-D \"mapred.job.name=MVP Summit Lightning\"");

            return configuration; 

        }
    }
}
