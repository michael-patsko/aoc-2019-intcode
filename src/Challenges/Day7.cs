using IntcodeComputer.Services;
using IntcodeComputer.Utilities;

namespace IntcodeComputer.Challenges
{
    public class Day7
    {
        public static int RunChallenge(string filePath)
        {
            IntcodeFileReader fileReader = new();

            // --- Day 7 ---
            int[] intcodeProgram = fileReader.ReadAndProcessIntcode(filePath);
            int[] programCopy = IntcodeUtility.CopyIntcodeProgram(intcodeProgram); // Create a clone of the intcode program

            int maxOutputSignal = -1;
            int[] nums = [0, 1, 2, 3, 4];
            int[][] phaseSettingSequences = GeneratePhaseSequences(nums);

            foreach (int[] phaseSettingSequence in phaseSettingSequences)
            {
                maxOutputSignal = Math.Max(maxOutputSignal, RunAmplificationCircuit(programCopy, phaseSettingSequence));
            }

            return maxOutputSignal;
        }

        static int RunAmplificationCircuit(int[] intcodeProgram, int[] phaseSettingSequence)
        {
            int inputSignal = 0;

            for (int i = 0; i < phaseSettingSequence.Length; i += 1)
            {
                int phaseSetting = phaseSettingSequence[i];
                inputSignal = IntcodeProcessor.ProcessIntcode(intcodeProgram, [phaseSetting, inputSignal]);
            }

            return inputSignal;
        }

        static int[][] GeneratePhaseSequences(int[] nums)
        {
            List<int[]> result = [];
            Permute(nums, 0, nums.Length - 1, result);

            // Convert List<int[]> to int[][]
            int[][] permutations = [.. result];

            return permutations;
        }

        static void Permute(int[] array, int start, int end, List<int[]> result)
        {
            if (start == end)
            {
                result.Add((int[])array.Clone());
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(ref array[start], ref array[i]);
                    Permute(array, start + 1, end, result);
                    Swap(ref array[start], ref array[i]);
                }
            }
        }

        static void Swap(ref int a, ref int b)
        {
            (b, a) = (a, b);
        }
    }
}