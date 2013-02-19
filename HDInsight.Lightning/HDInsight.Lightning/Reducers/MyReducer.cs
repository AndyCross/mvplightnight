using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Hadoop.MapReduce;

namespace HDInsight.Lightning.Reducers
{
    public class MyReducer : ReducerCombinerBase
    {
        public override void Reduce(string key, IEnumerable<string> values, ReducerCombinerContext context)
        {
            context.EmitKeyValue(key, values.Count().ToString(CultureInfo.InvariantCulture));
        }
    }
}
