using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

namespace IntcodeComputer.Challenges
{
    public class Day5
    {
        public static int RunChallenge(int inputValue)
        {
            IntcodeFileReader fileReader = new();

            // --- Day 5 ---
            string filepath = "../data/day5.txt";
            int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filepath);
            int[] programCopy;

            programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program
            int output = IntcodeProcessor.ProcessIntcode(programCopy, inputValue);

            return output;
        }
    }
}