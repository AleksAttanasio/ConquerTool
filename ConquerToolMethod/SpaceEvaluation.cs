using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConquerToolMethod
{
    public class SpaceEvaluation
    {
        static public float EvaluateDistance (int xStart, int yStart, int xEnd, int yEnd)
        {
            float distance = (float)Math.Sqrt(Math.Pow((xStart - xEnd), 2) + Math.Pow((yStart - yEnd), 2));

            return distance;
        }
    }
}
