using System;
using Xunit;
using FirstResponsiveWebAppKingslee;

namespace ResponsiveWebAppTests
{
    public class UnitTest1
    {
        
        [Fact]
        public void TestCaseforAgeThisYear()
        {
            //Arrange
            FirstResponsiveWebAppKingslee.Models.FirstResponsiveWebApp f = new FirstResponsiveWebAppKingslee.Models.FirstResponsiveWebApp();
            DateTime age = Convert.ToDateTime("10/17/1989");
            int expected = 31;
            int actual;
            //Act
            actual = f.AgeThisYear(age);
            //Assert
            Assert.Equal(expected, actual);
        }



        [Fact]
        public void TestCaseforAgeThisYearEnds()
        {
            //Arrange
            FirstResponsiveWebAppKingslee.Models.FirstResponsiveWebApp f = new FirstResponsiveWebAppKingslee.Models.FirstResponsiveWebApp();
            DateTime age = Convert.ToDateTime("10/17/1989");
            int expected = 32;
            int actual;
            //Act
            actual = f.AgeThisYearEnd(age);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCaseforAgeThatsZeroNowAndOneYearEnd()
        {
            //Arrange
            FirstResponsiveWebAppKingslee.Models.FirstResponsiveWebApp f = new FirstResponsiveWebAppKingslee.Models.FirstResponsiveWebApp();
            DateTime age = Convert.ToDateTime("10/02/2020");
            int expected = 1;
            int actual;
            //Act
            actual = f.AgeThisYearEnd(age);
            //Assert
            Assert.Equal(expected, actual);
        }
        }
}
