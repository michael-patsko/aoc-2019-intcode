using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

namespace IntcodeComputer.Challenges
{
    public class Day5
    {
        public static int RunChallenge(string filePath, int inputValue)
        {
            IntcodeFileReader fileReader = new();

            // --- Day 5 ---
            int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filePath);
            int[] programCopy;

            programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program
            int output = IntcodeProcessor.ProcessIntcode(programCopy, [inputValue]);

            return output;
        }
    }
}