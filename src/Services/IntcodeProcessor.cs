namespace IntcodeComputer.Services
{
    public class IntcodeProcessor
    {
        public static void ProcessIntcode(int[] intcodeProgram)
        {
            int opcode;
            int instructionLength;

            for (int i = 0; i < intcodeProgram.Length; i += instructionLength)
            {
                opcode = intcodeProgram[i];

                switch (opcode)
                {
                    case 1:
                        {
                            instructionLength = 4;

                            int input1Index = intcodeProgram[i + 1];
                            int input2Index = intcodeProgram[i + 2];
                            int outputIndex = intcodeProgram[i + 3];

                            int input1 = intcodeProgram[input1Index];
                            int input2 = intcodeProgram[input2Index];
                            int outputValue = input1 + input2;

                            intcodeProgram[outputIndex] = outputValue;
                            break;
                        }
                    case 2:
                        {
                            instructionLength = 4;

                            int input1Index = intcodeProgram[i + 1];
                            int input2Index = intcodeProgram[i + 2];
                            int outputIndex = intcodeProgram[i + 3];

                            int input1 = intcodeProgram[input1Index];
                            int input2 = intcodeProgram[input2Index];
                            int outputValue = input1 * input2;

                            intcodeProgram[outputIndex] = outputValue;
                            break;
                        }
                    case 99:
                        { return; }
                    default:
                        { throw new Exception($"Invalid opcode: {opcode}"); }
                }
            }
        }
    }
}