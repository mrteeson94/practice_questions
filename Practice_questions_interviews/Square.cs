using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_questions_interviews
{
    public class Square : IShape
    {
        public float Length { get; set; }

        public Square(float _length)
        {
            Length = _length;
        }

        public float CalculateArea()
        {
            return Length * Length;
        }

        public float CalculatePerimeterLength()
        {
            return Length * 4;
        }
    }
}
