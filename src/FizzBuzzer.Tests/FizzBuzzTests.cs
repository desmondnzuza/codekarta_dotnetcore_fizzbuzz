using System;
using Xunit;

namespace FizzBuzzer.Tests
{
    public class FizzBuzzTests
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(17)]
        public void FizzBuzzTests_WhenNormalNumber_Expect_NumberAsString(int input)
        {            
            //Arrange
            var sut = new FizzBuzz();
            var expected = input.ToString();

            //Act
            var response = sut.Execute(input);

            //Assert
            Assert.Equal(expected, response);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void FizzBuzzTests_WhenDivisibleBy3_Expect_Fizz(int input)
        {            
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var response = sut.Execute(input);

            //Assert
            Assert.Equal("Fizz", response);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(20)]
        public void FizzBuzzTests_WhenDivisibleBy5_Expect_Buzz(int input)
        {            
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var response = sut.Execute(input);

            //Assert
            Assert.Equal("Buzz", response);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void FizzBuzzTests_WhenDivisibleByBoth3And5_Expect_FizzBuzz(int input)
        {            
            //Arrange
            var sut = new FizzBuzz();

            //Act
            var response = sut.Execute(input);

            //Assert
            Assert.Equal("FizzBuzz", response);
        }
    }
}
