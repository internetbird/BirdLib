using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.ExtensionMethods
{
    public static class PointExtensions
    {
        public static Point ParsePoint(this string pointStr)
        {
            pointStr = pointStr.Trim('{', '}');

            string[] parts = pointStr.Split(',');

            int x = int.Parse(parts[0].Substring(2));
            int y = int.Parse(parts[1].Substring(2));

            return new Point(x, y);

        }
    }
}
