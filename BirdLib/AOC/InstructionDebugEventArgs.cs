namespace BirdLib.AOC
{
    public class InstructionDebugEventArgs<T>
    {
        public IComputerInstruction<T> CurrentInstrunction { get; set; }
    }
}