using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAnAverageGrade()
        {
            // arrange
            var book = new InMemoryBook("");
            book.AddGrade(80.5);
            book.AddGrade(91.2);
            book.AddGrade(13.6);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(61.8, result.Average, 1);
            Assert.Equal(91.2, result.High, 1);
            Assert.Equal(13.6, result.Low, 1);
            Assert.Equal('D', result.Letter);
        }
    }
}
