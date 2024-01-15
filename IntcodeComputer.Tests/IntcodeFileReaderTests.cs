using IntcodeComputer.Services;
using Xunit;

namespace IntcodeComputer.Tests
{
    public class IntcodeFileReaderTests
    {
        [Fact]
        public void ReadAndProcessIntcode_ShouldReturnCorrectIntArray()
        {
            var reader = new IntcodeFileReader();
            string testFilePath = "data/IntcodeTestFile.txt";
            int[] expected = { 1, 9, 10, 3, 2, 3, 11, 0, 99, 30, 40, 50 };

            int[] result = reader.ReadAndProcessIntcode(testFilePath);

            Assert.Equal(expected, result);
        }
    }
}
