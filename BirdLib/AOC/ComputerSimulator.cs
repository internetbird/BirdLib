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
            _registers = new Dictionary<string, int>();
        }

        public string ExcuteProgram()
        {
            _programCounter = 0;

            T instructionToExecute = GetNextInstructionToExecute();

            while (instructionToExecute != null)
            {
                ExecuteInsturction(instructionToExecute);
                instructionToExecute = GetNextInstructionToExecute();
            }

            return string.Empty;
        }

        protected abstract void ExecuteInsturction(T instructionToExecute);

        protected int GetOperandValue(string operandStr)
        {
            if (_registers.ContainsKey(operandStr)) //Check if the operand is a register
            {
                return _registers[operandStr];
            }
            return int.Parse(operandStr);
        }

        protected void SetRegisterValue(string register, int value)
        {
            if (!_registers.ContainsKey(register))
            {
                _registers.Add(register, value);

            } else
            {
                _registers[register] = value;
            }
        }

        protected int GetRegisterValue(string register)
        {
            if (_registers.ContainsKey(register))
            {
                return _registers[register];
            }

            return 0;
        }


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
            _program = new List<T>();

            foreach (string line in programLines)
            {
                T instruction = _parser.ParseInstruction(line);
                _program.Add(instruction);
            }
        }
    }
}
