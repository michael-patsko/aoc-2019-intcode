using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

namespace IntcodeComputer.Challenges
{
    public class Day2
    {
        public static void RunChallenge()
        {
            IntcodeFileReader fileReader = new();

            // --- Day 2 ---
            Console.WriteLine("\n--- Day 2 ---");

            string filepath = "../data/day2.txt";
            int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filepath);
            int[] programCopy;
            int result;

            // --- Part 1 ---
            Console.WriteLine("\n--- Part 1 ---");

            programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program
            IntcodeUtility.ModifyNounAndVerb(programCopy, 12, 2);
            IntcodeProcessor.ProcessIntcode(programCopy);

            result = programCopy[0];
            Console.WriteLine($"Program output for noun 12 and verb 2: {result}");

            // --- Part 2 ---
            Console.WriteLine("\n--- Part 2 ---");

            // Declare target output
            int targetValue = 19690720;

            // Iterate over all noun-verb combinations
            for (int noun = 0; noun <= 99; noun++)
            {
                for (int verb = 0; verb <= 99; verb++)
                {
                    programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program
                    IntcodeUtility.ModifyNounAndVerb(programCopy, noun, verb); // Replace the noun and verb of the program with our current combination
                    IntcodeProcessor.ProcessIntcode(programCopy); // Process the intcode program

                    result = programCopy[0]; // Retrieve our output
                    if (result == targetValue)
                    {
                        Console.WriteLine($"Target value {targetValue} found for noun {noun} and verb {verb}.");
                        Console.WriteLine($"\nOutput: {100 * noun + verb}\n");
                        return; // Target output has been reached
                    }
                }
            }
            Console.WriteLine($"Target value not found.");
        }
    }
}