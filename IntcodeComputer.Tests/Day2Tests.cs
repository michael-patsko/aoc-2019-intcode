using IntcodeComputer.Services;
using IntcodeComputer.Utilities;
using IntcodeComputer.Challenges;
using Xunit;

namespace IntcodeComputer.Tests
{
    public class Day2Tests
    {
        [Fact]
        public void RunChallenge_ShouldReturnCorrectInts()
        {
            string testFilePath = "data/Day2TestFile.txt";
            int[] expected = { 4023471, 8051 };

            int[] result = Day2.RunChallenge(testFilePath);

            Assert.Equal(expected, result);
        }
    }
}