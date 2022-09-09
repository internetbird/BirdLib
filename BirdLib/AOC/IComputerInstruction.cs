using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.AOC
{
    public interface IComputerInstruction<T>
    {
        T Type { get; set; }
        public string Operand1 { get; set; }
        public string Operand2 { get; set; }

    }
}
