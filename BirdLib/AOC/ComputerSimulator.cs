using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.AOC
{
    public abstract class ComputerSimulator<T,U> where T : IComputerInstruction<U>
    {
        protected Dictionary<string, int> _registers;
        protected List<T> _program;
        private IComputerInstructionParser<T,U> _parser;
        protected int _programCounter;

        public ComputerSimulator(IComputerInstructionParser<T,U> parser)
        {
            _parser = parser;
        }

        public string ExcuteProgram()
        {
            _programCounter = 0;

            T instructionToExecute = GetNextInstructionToExecute();

            while (instructionToExecute != null)
            {
                ExecuteInsturction(instructionToExecute);
            }

            return string.Empty;
        }

        protected abstract void ExecuteInsturction(T instructionToExecute);
       
        private T GetNextInstructionToExecute()
        {
            if (_programCounter < _program.Count)
            {
                return _program[_programCounter];
            }

            return default(T);
        }

        public void LoadProgram(string[] programLines)
        {
            foreach (string line in programLines)
            {
                T instruction = _parser.ParseInstruction(line);
                _program.Add(instruction);
            }
        }
    }
}
