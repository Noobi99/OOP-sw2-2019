using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lektion2
{
    public class Vector2D
    {
        public Vector2 Add(Vector2 vec1, Vector2 vec2)
        {
            return vec1 + vec2;
        }

        public Vector2 Sub(Vector2 vec1, Vector2 vec2)
        {
            return vec1 - vec2;
        }

        public float Scalar(Vector2 vec1, Vector2 vec2)
        {
            return vec1.X * vec2.X + vec1.Y * vec2.Y;
        }

        // bliver ikke brugt
        public double Length(Vector2 vec)
        {
            return Math.Sqrt((vec.X * vec.X) + (vec.Y * vec.Y));
        }

    }
}
