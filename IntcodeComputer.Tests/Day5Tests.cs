using IntcodeComputer.Services;
using IntcodeComputer.Utilities;
using IntcodeComputer.Challenges;
using Xunit;

namespace IntcodeComputer.Tests
{
    public class Day5Tests
    {
        [Fact]
        public void RunChallenge_ShouldReturnCorrectInts()
        {
            string testFilePath = "data/Day5TestFile.txt";
            int[] expected = { 9006673, 3629692 };

            int[] result = [Day5.RunChallenge(testFilePath, 1), Day5.RunChallenge(testFilePath, 5)];

            Assert.Equal(expected, result);
        }
    }
}