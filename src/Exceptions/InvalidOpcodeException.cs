namespace IntcodeComputer.Exceptions
{
    public class InvalidOpcodeException : Exception
    {
        public int Opcode { get; }

        public InvalidOpcodeException(int opcode)
            : base($"Invalid opcode: {opcode}")
        {
            Opcode = opcode;
        }
    }
}