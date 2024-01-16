using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

class Program
{
    static void Main()
    {
        string filepath = "../data/day2.txt";

        IntcodeFileReader fileReader = new();

        int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filepath);
        IntcodeUtility.ModifyNounAndVerb(intcodeProgram, 12, 2);
        IntcodeProcessor.ProcessIntcode(intcodeProgram);
        int result = intcodeProgram[0];
        Console.WriteLine($"Result at address 0 after processing intcode program: {result}");
    }
}