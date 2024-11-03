using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator.Tests
{
    [TestFixture]
    public class AgeCalculatorTests
    {
        private AgeCalculator _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new AgeCalculator();
        }

        [TestCase("1990/02/23", "2001/10/05", 11)]
        [TestCase("1984/06/27", "2002/11/01", 18)]
        [TestCase("2000/01/01", "2010/01/02", 10)]
        [TestCase("2000/01/01", "2010/01/01", 10)]

        public void GivenOnOrAfterBirthday_ShouldReturnDifferentsInYears(DateTime birthDate, DateTime targetDate, int expectedAge)
            
        {
            //act
            var actual = _sut.GetAge(birthDate, targetDate);
            //assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }

        [TestCase("2000/06/30", "2020/03/21", 19)]

        [TestCase("2010/10/01", "2021/07/31", 10)]
        public void GivenBeforeBirthdayMonth_ShouldReturnDifferentsInYearsMinusOne(DateTime birthDate, DateTime targetDate, int expectedAge)

        {
            //act
            var actual = _sut.GetAge(birthDate, targetDate);
            //assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }
        [TestCase("2001/06/30", "2020/06/21", 18)]
        [TestCase("2005/02/28", "2010/02/27", 4)]

        public void GivenBeforeBirthdayDayInMonth_ShouldReturnDifferentsInYearsMinusOne(DateTime birthDate, DateTime targetDate, int expectedAge)

        {
            //act
            var actual = _sut.GetAge(birthDate, targetDate);
            //assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }
        [TestCase("2000/02/29", "2004/02/29", 4)]
        [TestCase("2000/02/29", "2004/03/01", 4)]
        [TestCase("2000/02/29", "2005/02/28", 4)]
        public void GiveneBirthdayOnLeapYear_ShouldReturnDifferentsInYears(DateTime birthDate, DateTime targetDate, int expectedAge)

        {
            //act
            var actual = _sut.GetAge(birthDate, targetDate);
            //assert
            Assert.That(actual, Is.EqualTo(expectedAge));
        }
    }
}
