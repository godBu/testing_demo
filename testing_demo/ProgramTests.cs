using System;
using Xunit;

namespace testing_demo
{
    public class ProgramTests
    {
        Program program = new Program();

        [Fact]
        public void GoodTest()
        {
            Assert.Equal(10, program.Addition(1, 9)); // asserting that the sum of numbers equal 10
        }

        [Fact]
        public void BadTest()
        {
            Assert.Equal(10, program.Addition(10, 90)); // asserting that the sum of numbers equal 100
        }

        [Fact]
        public void TruthChecker()
        {
            Assert.True(program.TheCheckerOfTruth(true));
        }

        [Fact]
        public void NameChecker()
        {
            Assert.Contains("Ebuka", program.UserName("Ebuka"));
        }    
    }
}
