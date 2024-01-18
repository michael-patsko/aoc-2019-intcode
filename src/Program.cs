using IntcodeComputer.Challenges;

class Program
{
    static void Main()
    {
        int[] Day2Results = Day2.RunChallenge("../data/day2.txt");
        int[] Day5Results = [Day5.RunChallenge("../data/day5.txt", 1), Day5.RunChallenge("../data/day5.txt", 5)];
        int Day7Result = Day7.RunChallenge("../data/day7.txt");
        Console.WriteLine($"Day 2 Part 1: {Day2Results[0]}, Part 2: {Day2Results[1]}");
        Console.WriteLine($"Day 5 Part 1: {Day5Results[0]}, Part 2: {Day5Results[1]}");
        Console.WriteLine($"Day 7 Part 1: {Day7Result}");
    }
}