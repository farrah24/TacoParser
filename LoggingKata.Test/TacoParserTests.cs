using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.035985, -84.683302, Taco Bell Acwort...", -84.683302)]
        [InlineData("34.087508, -84.575512, Taco Bell Acwort...", -84.575512)]
        [InlineData("34.376395, -84.913185, Taco Bell Adairsvill...", -84.913185)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", -86.805275)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", -84.10353)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.035985, -84.683302, Taco Bell Acwort...", 34.035985)]
        [InlineData("34.087508, -84.575512, Taco Bell Acwort...", 34.087508)]
        [InlineData("34.376395, -84.913185, Taco Bell Adairsvill...",34.376395)]
        [InlineData("33.22997, -86.805275, Taco Bell Alabaste...", 33.22997)]
        [InlineData("31.570771, -84.10353, Taco Bell Albany...", 31.570771)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();
            //Act
            var actual = tacoParser.Parse(line);
            //Assert
            Assert.Equal(expected, actual.Location.Latitude);
        }

    }
}
