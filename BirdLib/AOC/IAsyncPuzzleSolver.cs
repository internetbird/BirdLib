using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.AOC
{
    public interface IAsyncPuzzleSolver
    {
        Task<string> SolvePuzzlePart1();
        Task<string> SolvePuzzlePart2();
    }
}
