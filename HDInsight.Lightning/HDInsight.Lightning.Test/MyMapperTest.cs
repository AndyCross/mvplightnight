using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HDInsight.Lightning.Mappers;
using HDInsight.Lightning.Reducers;
using Microsoft.Hadoop.MapReduce;
using NUnit.Framework;

namespace HDInsight.Lightning.Test
{
    [TestFixture]
    public class MyMapperTest
    {
        [Test]
        public void MyMapper_Map_ExtractsCountry()
        {
            //arrange
            var inputLine = "something\tsomething\tsomething\tEngland\tsomething\tsomething";
            var inputArray = new[] {inputLine};
            var expected = "England\t1";

            //act
            var streamingResult = StreamingUnit.Execute<MyMapper, MyReducer>(inputArray);
            var firstResult = streamingResult.MapperResult.First();

            //assert
            Assert.AreEqual(expected, firstResult);
        }

        [Test]
        public void MyMapper_Map_SkipsInvalidLine()
        {
            //arrange
            var inputLine = "this is an invalid input line";
            var inputArray = new[] { inputLine };
            var expected = 0;

            //act
            var streamingResult = StreamingUnit.Execute<MyMapper, MyReducer>(inputArray);
            var numberOfResults = streamingResult.MapperResult.Count();

            //assert
            Assert.AreEqual(expected, numberOfResults);
        }
    }
}
