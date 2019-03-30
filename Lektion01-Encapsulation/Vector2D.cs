using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows;

// Vector er i WindowsBase - using System.Windows

namespace Lektion1
{
    public class Vector2D
    {
        public Vector AddVectors(Vector vecA, Vector vecB)
        {
            return vecA + vecB;
        }

        public Vector SubVectors(Vector vecA, Vector vecB)
        {
            return vecA - vecB;
        }

    }
}
