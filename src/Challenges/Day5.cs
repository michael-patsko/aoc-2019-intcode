using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

namespace IntcodeComputer.Challenges
{
    public class Day5
    {
        public static void RunChallenge(int inputValue)
        {
            IntcodeFileReader fileReader = new();

            // --- Day 5 ---
            Console.WriteLine("\n--- Day 5 ---");

            string filepath = "../data/day5.txt";
            int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filepath);
            int[] programCopy;

            // --- Part 1 ---
            Console.WriteLine("\n--- Part 1 ---");

            programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program
            IntcodeProcessor.ProcessIntcode(programCopy, inputValue);
        }
    }
}