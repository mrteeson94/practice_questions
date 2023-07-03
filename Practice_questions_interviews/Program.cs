using System;

namespace Practice_questions_interviews
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            
            
            //** Basic string manipulation **
            //Create app asking for user full name, age 
            //output: valid input message, fullname, firstname, lastname, age and recommended fullname nickname(replace given fullname with reversed version)

            //i. input
            //Console.Write("What is your fullname?: ");
            //var fullName = Console.ReadLine();
            //Console.WriteLine(fullName);

            //fullName = fullName.Trim();
            //var firstName = 
            //Console.WriteLine(fullName);

        }

        public IShape FindLargestArea(IShape[] shapes)
        {
            //1.var to track index containing highest area
            IShape largestAreaShape = shapes[shapes.Length -1];
            //2. foreach to loop
            for (int i = 0; i < shapes.Length - 1; i++)
            {
                var area = shapes[i].CalculateArea();
                if (area > largestAreaShape.CalculateArea())
                {
                    largestAreaShape = shapes[i];
                }
            }
            return largestAreaShape;

            //return index that is stored in var
            //foreach (var shape in shapes)
            //{
            //    //2i. var to area of each object
            //    var area = shape.CalculateArea();
            //    //2ii. area of object compare with current highest area variable.
            //    if (area > largestAreaShape.CalculateArea())
            //    {
            //        largestAreaShape = shape;
            //    }
            //}


        }

    }
}
