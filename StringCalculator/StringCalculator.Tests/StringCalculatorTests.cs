using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace StringCalculator.Tests
{
    public class StringCalculatorTests
    {
        // for an empty string it will return 0
        [Fact]
        public void for_an_empty_string_it_will_return_0()
        {
            // Arrange
            //var _stringCalculator = new Calculator();

            //Act
            int actual = Calculator.Add("");
            int expected = 0;

            //Assert
            actual.Should().Be(expected);
        }

        //for string = 2 it should return 2
        [Fact]
        public void for_string_2_it_should_return_2()
        {
            //Arrange
            //Act
            int actual = Calculator.Add("2");
            int expected = 2;

            //Assert
            actual.Should().Be(expected);
        }

        //for string "1,2" it should return 3
        [Fact]
        public void for_string_1_2_it_should_return_3()
        {
            int actual = Calculator.Add("1,2");
            int expected = 3;

            actual.Should().Be(expected);
        }

        //should handle new lines between numbers
        [Fact]
        public void handle_new_lines_between_numbers()
        {
            int actual = Calculator.Add("1\n2,3");
            int expected = 6;

            actual.Should().Be(expected);
        }
        //should support different delimiters 
        [Fact]
        public void support_different_delimiters()
        {
            int actual = Calculator.Add("//;\n1;2");
            int expected = 3;
            actual.Should().Be(expected);

        }
        // negative number should throw an exception “negatives not allowed” 
        [Fact]
        public void negative_number_should_throw_an_exception()
        {
            Action act = () =>Calculator.Add("-2, 2");
            act.ShouldThrow<ArgumentException>().WithMessage("negatives not allowed");
        }


    }

}
