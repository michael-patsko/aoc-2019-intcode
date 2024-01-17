using IntcodeComputer.Exceptions;

namespace IntcodeComputer.Services
{
    public class IntcodeProcessor
    {
        private static int GetParameter(int[] intcodeProgram, int index, int mode)
        {
            if (mode == 0)
            {
                return intcodeProgram[intcodeProgram[index]]; // Position mode
            }
            else if (mode == 1)
            {
                return intcodeProgram[index]; // Immediate mode
            }
            else
            {
                throw new InvalidOperationException($"Unsupported parameter mode: {mode}");
            }
        }
        public static void ProcessIntcode(int[] intcodeProgram, int? programInput = null)
        {

            for (int i = 0; i < intcodeProgram.Length;)
            {
                int instruction = intcodeProgram[i];

                int opcode = instruction % 100;
                int mode1 = instruction / 100 % 10;
                int mode2 = instruction / 1000 % 10;

                int param1, param2;
                switch (opcode)
                {
                    case 1:
                    case 2:
                        {
                            param1 = GetParameter(intcodeProgram, i + 1, mode1);
                            param2 = GetParameter(intcodeProgram, i + 2, mode2);
                            int outputIndex = intcodeProgram[i + 3];

                            if (opcode == 1)
                            {
                                intcodeProgram[outputIndex] = param1 + param2;
                            }
                            else if (opcode == 2)
                            {
                                intcodeProgram[outputIndex] = param1 * param2;
                            }
                            i += 4;
                            break;
                        }
                    case 3:
                        {
                            int parameterIndex = intcodeProgram[i + 1];
                            intcodeProgram[parameterIndex] = programInput ?? throw new InvalidOperationException("Program input cannot be null.");

                            i += 2;
                            break;
                        }
                    case 4:
                        {
                            param1 = GetParameter(intcodeProgram, i + 1, mode1);
                            Console.WriteLine($"Opcode 4 reached. Output: {param1}");

                            i += 2;
                            break;

                        }
                    case 99:
                        { return; }
                    default:
                        { throw new InvalidOpcodeException(opcode); }
                }
            }
        }
    }
}