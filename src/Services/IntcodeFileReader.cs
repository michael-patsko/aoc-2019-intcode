namespace IntcodeComputer.Services
{
    public class IntcodeFileReader
    {
        public int[]? LastProcessedIntcodeProgram { get; private set; }

        public int[] ReadAndProcessIntcode(string filepath)
        {
            string rawIntcode = File.ReadAllText(filepath);

            int[] intcodeProgram = ParseRawIntcode(rawIntcode);

            LastProcessedIntcodeProgram = intcodeProgram;

            return intcodeProgram;
        }

        private static int[] ParseRawIntcode(string rawIntcode)
        {
            int[] intcodeProgram = rawIntcode.Split(",").Select(int.Parse).ToArray();
            return intcodeProgram;
        }
    }
}