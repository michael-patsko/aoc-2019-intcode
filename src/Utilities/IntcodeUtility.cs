namespace IntcodeComputer.Utilities
{
    public class IntcodeUtility
    {
        public static void ModifyNounAndVerb(int[] intcodeProgram, int noun, int verb)
        {
            intcodeProgram[1] = noun;
            intcodeProgram[2] = verb;
        }
    }
}