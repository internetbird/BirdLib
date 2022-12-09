namespace BirdLib.AOC
{
    public class InstructionExecutedEventArgs<T>
    {
        public IComputerInstruction<T> CurrentInstrunction { get; set; }
    }
}