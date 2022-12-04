using BirdLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.ExtensionMethods
{
    public static class DirectionExtensions
    {
        public static Direction TurnRight(this Direction direction)
        {
            Direction newDirection = Direction.Up;
            switch (direction)
            {
                case Direction.Right:
                    newDirection = Direction.Down;
                    break;
                case Direction.Up:
                    newDirection = Direction.Right;
                    break;
                case Direction.Left:
                    newDirection = Direction.Up;
                    break;
                case Direction.Down:
                    newDirection = Direction.Left;
                    break;
            }

            return newDirection;
        }

        public static Direction TurnLeft(this Direction direction)
        {
            Direction newDirection = Direction.Up;
            switch (direction)
            {
                case Direction.Right:
                    newDirection = Direction.Up;
                    break;
                case Direction.Up:
                    newDirection = Direction.Left;
                    break;
                case Direction.Left:
                    newDirection = Direction.Down;
                    break;
                case Direction.Down:
                    newDirection = Direction.Right;
                    break;
            }

            return newDirection;
        }

    }
}
