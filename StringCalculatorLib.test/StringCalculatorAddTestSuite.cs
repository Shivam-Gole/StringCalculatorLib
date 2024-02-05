using StringCalculatorLib;


    namespace StringCalculatorLib.test
{
    // This class act as Test Suite
    public class StringCalculatorAddTestSuite
    {
        [Fact] // test case
        public void GivenEmptyStringZeroIsExpected() // Never return annything from test cases
        {
            //AAA
            string input = "";
            int expectedResult = 0;
            //ACT
            int actualResult = StringCalculatorLib.StringCalculator.Add(input);
            //Assert
            Assert.Equal(expectedResult, actualResult); 

        }

        [Fact]
        public void GivenSingleDigitReturnsTheDigitItself()
        {
            // Arrange
            string input = "1";
            int expectedResult = 1;

            // Act
            int actualResult = StringCalculator.Add(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GivenCommaSeparatedNumbersSumCorrectly()
        {
            // Arrange
            string input = "1,2";
            int expectedResult = 3;

            // Act
            int actualResult = StringCalculator.Add(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GivenNegativeNumberThrowsException()
        {
            // Arrange
            string input = "1,-2";

            // Act and Assert
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(input));
        }

        [Fact]
        public void GivenNewlineAndCommaSeparatedNumbersSumCorrectly()
        {
            // Arrange
            string input = "1\n2,3";
            int expectedResult = 6;

            // Act
            int actualResult = StringCalculator.Add(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void GivenLeadingZerosIgnored()
        {
            // Arrange
            string input = "1001,1";
            int expectedResult = 1;

            // Act
            int actualResult = StringCalculator.Add(input);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}