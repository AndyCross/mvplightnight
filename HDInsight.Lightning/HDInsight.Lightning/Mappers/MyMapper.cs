using Microsoft.Hadoop.MapReduce;

namespace HDInsight.Lightning.Mappers
{
    public class MyMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            string[] terms = inputLine.Split('\t');
            // add a sanity check in case we have a data quality issue 
            if (terms.Length != 6) return; 

            // get the country part out 
            string country = terms[3]; 
            context.EmitKeyValue(country, "1"); 

        }
    }
}
