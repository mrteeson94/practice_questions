

using System;

namespace Practice_questions_interviews
{
    public class Circle : IShape
    {
        public float Radius { get; set; }

        public Circle(float _radius)
        {
            Radius = _radius;
        }

        public float CalculateArea()
        { 
            return  (float)3.14 * (float)Math.Pow(Radius, 2);
        }

        public float CalculatePerimeterLength()
        {
            return 2 * (float)3.14 * Radius ;
        }
    }
}
