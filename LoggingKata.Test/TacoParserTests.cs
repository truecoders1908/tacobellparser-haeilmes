using System;
using Xunit;
using LoggingKata;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything
        }

        [Theory]
        [InlineData("32.571331,-85.499655,Taco Bell Auburn")]
        [InlineData("34.063779,-84.07354,Taco Bell Suwanee")]
        [InlineData("36,-88, Taco Bell")]
        public void ShouldParse(string str)
        {
            //Arrange
            TacoParser parsed = new TacoParser();

            //Act
            ITrackable actual = parsed.Parse(str);

            //Assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ShouldFailParse(string str)
        {
            //Arrange
            TacoParser parsed = new TacoParser();

            //Act
            ITrackable actual = parsed.Parse(str);

            //Assert
            Assert.Null(actual);
        }
    }
}
