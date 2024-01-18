using IntcodeComputer.Services;
using IntcodeComputer.Utilities;
using IntcodeComputer.Challenges;
using Xunit;

namespace IntcodeComputer.Tests
{
    public class Day7Tests
    {
        [Fact]
        public void RunChallenge_ShouldReturnCorrectInts()
        {
            string testFilePath1 = "data/Day7TestFile1.txt";
            string testFilePath2 = "data/Day7TestFile2.txt";
            int[] expected = { 225056, 65210 };

            int[] result = [Day7.RunChallenge(testFilePath1), Day7.RunChallenge(testFilePath2)];

            Assert.Equal(expected, result);
        }
    }
}