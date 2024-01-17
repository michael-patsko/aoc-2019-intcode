using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

namespace IntcodeComputer.Challenges
{
    public class Day2
    {
        public static int[] RunChallenge(string filePath)
        {
            IntcodeFileReader fileReader = new();
            int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filePath);
            int[] programCopy;
            int resultPart1;
            int resultPart2;

            // --- Part 1 ---
            programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program
            IntcodeUtility.ModifyNounAndVerb(programCopy, 12, 2);
            IntcodeProcessor.ProcessIntcode(programCopy);

            resultPart1 = programCopy[0];

            // --- Part 2 ---
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

                    resultPart2 = programCopy[0]; // Retrieve our output
                    if (resultPart2 == targetValue)
                    {
                        return [resultPart1, 100 * noun + verb]; // Target output has been reached
                    }
                }
            }

            throw new Exception("Target value not reached for any noun or verb.");
        }
    }
}
