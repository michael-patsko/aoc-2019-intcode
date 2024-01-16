using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

class Program
{
    static void Main()
    {
        string filepath = "../data/day2.txt";

        IntcodeFileReader fileReader = new();

        int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filepath);

        int targetValue = 19690720;

        for (int noun = 0; noun <= 99; noun++)
        {
            for (int verb = 0; verb <= 99; verb++)
            {
                int[] programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram);
                IntcodeUtility.ModifyNounAndVerb(programCopy, noun, verb);
                IntcodeProcessor.ProcessIntcode(programCopy);

                int result = programCopy[0];
                if (result == targetValue)
                {
                    Console.WriteLine($"Target value {targetValue} found for noun {noun} and verb {verb}.");
                    Console.WriteLine(100 * noun + verb);
                    return;
                }
            }
        }
        Console.WriteLine($"Target value not found.");
    }
}