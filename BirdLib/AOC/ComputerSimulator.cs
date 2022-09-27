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
        protected Dictionary<string, long> _registers;
        protected List<T> _program;
        private IComputerInstructionParser<T,U> _parser;
        protected int _programCounter;
        protected string[] _programLines;
        protected bool _isDebugMode;
       

        public ComputerSimulator(IComputerInstructionParser<T,U> parser)
        {
            _parser = parser;
            _registers = new Dictionary<string, long>();
        }

        public string ExcuteProgram(bool debugMode  = false)
        {
            _isDebugMode = debugMode;
            _programCounter = 0;

            T instructionToExecute = GetNextInstructionToExecute();

            while (instructionToExecute != null)
            {
                if (debugMode)
                {
                    DebugNextInstructionToExecute();
                }

                ExecuteInsturction(instructionToExecute);
                instructionToExecute = GetNextInstructionToExecute();
            }

            return string.Empty;
        }

        private void DebugNextInstructionToExecute()
        {
            Console.WriteLine($"Executing command : {_programLines[_programCounter]} - At line {_programCounter + 1}");

            LogRegisters();

            Console.ReadKey();
        }

        private void LogRegisters()
        {
            if (_registers.Count > 0)
            {
                Console.WriteLine("**** Registers *******");

                foreach(var kvp in _registers)
                {
                    Console.WriteLine($"{kvp.Key} = {kvp.Value}");
                }

                Console.WriteLine("**********************");
            }
        }

        protected abstract void ExecuteInsturction(T instructionToExecute);

        protected long GetOperandValue(string operandStr)
        {
            if (_registers.ContainsKey(operandStr)) //Check if the operand is a register
            {
                return _registers[operandStr];
            }
            return long.Parse(operandStr);
        }

        protected void SetRegisterValue(string register, long value)
        {
            if (!_registers.ContainsKey(register))
            {
                _registers.Add(register, value);

            } else
            {
                _registers[register] = value;
            }
        }

        protected long GetRegisterValue(string register)
        {
            if (_registers.ContainsKey(register))
            {
                return _registers[register];
            }

            return 0;
        }


        protected virtual T GetNextInstructionToExecute()
        {
            if (_programCounter < _program.Count)
            {
                return _program[_programCounter];
            }

            return default(T);
        }

        public void LoadProgram(string[] programLines)
        {
            _programLines = programLines; //Save for debuggin purposes

            _program = new List<T>();

            foreach (string line in programLines)
            {
                T instruction = _parser.ParseInstruction(line);
                _program.Add(instruction);
            }
        }
    }
}
