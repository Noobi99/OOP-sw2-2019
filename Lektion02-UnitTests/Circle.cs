using System;
using System.Drawing;
using System.Net.NetworkInformation;


namespace Lektion2
{
    public enum CircleState
    {
        inside,
        outside,
        on,
        def
    }

    public class Circle
    {
        public Point center;
        public float radius;

        public CircleState DetermineInsideCircle(Point point)
        {
            double d = Math.Sqrt(((point.X - center.X) * (point.X - center.X)) + ((point.Y - center.Y) * (point.Y - center.Y)));
            
            double radiusSquared = radius;

            if (d < radiusSquared)
                return CircleState.inside;

            if (d > radiusSquared)
                return CircleState.outside;

            if (d == radiusSquared)
                return CircleState.on;

            return CircleState.def;
        }

    }
}