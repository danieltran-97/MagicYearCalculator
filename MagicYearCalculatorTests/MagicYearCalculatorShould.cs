using System;
using Moq;
using Xunit;

namespace MagicYearCalculator
{
    public class MagicYearCalculatorShould
    {
        [Fact]
        public void GetFullName()
        {
            var magicYearCalculator = new MagicYearCalculator("John", "Doe", It.IsAny<int>(), It.IsAny<int>());
            var fullName = magicYearCalculator.GetFullName();

            Assert.Equal("John Doe", fullName);
        }

        [Fact]
        public void GetMonthlySalary()
        {
            var magicYearCalculator = new MagicYearCalculator(It.IsAny<string>(), It.IsAny<string>(), 60050, It.IsAny<int>());
            var monthlySalary = magicYearCalculator.GetMonthlySalary();
        
            Assert.Equal(5004, monthlySalary);
        }
        
        [Fact]
        public void GetMagicYear()
        {
            var magicYearCalculator = new MagicYearCalculator(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>(), 1980);
            var magicYear = magicYearCalculator.GetMagicYear();
        
            Assert.Equal(2045, magicYear);
        }
    }
}