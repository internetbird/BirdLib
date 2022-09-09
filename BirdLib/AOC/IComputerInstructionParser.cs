using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.AOC
{
    public interface IComputerInstructionParser<T,U> where T : IComputerInstruction<U>
    {
        public T ParseInstruction(string line);
    }
}
