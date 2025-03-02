using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk7Ex2
{
    internal class Program
    {
        //create class for book
        public class Shape
        {
            //method to calculate area
            public virtual void CalculateArea()
            {
                Console.WriteLine("This is the area of the shape");
            }
        }

        //create class for circle
        public class Circle : Shape
        {
            //declare radius
            public double Radius { get; set; }
            //method to calculate area
            public override void CalculateArea()
            {
                //calculate area of circle
                double area = 3.14 * (Radius *= Radius);
                //output area
                Console.WriteLine(area);
            }
        }

        //create class for rectangle
        public class Rectangle : Shape
        {
            //declarations
            public double Length { get; set; }
            public double Width { get; set; }

            //method to calculate area
            public override void CalculateArea()
            {
                //calculate area of rectangle
                double area = Length * Width;
                //output area
                Console.WriteLine(area);
            }
        }

        //create class for triangle
        public class Triangle : Shape
        {
            //declarations
            public double Base { get; set; }
            public double Height { get; set; }

            //method to calculate area
            public override void CalculateArea()
            {
                //calculate area of triangle
                double area = 0.5 * Base * Height;
                //output area
                Console.WriteLine(area);
            }
        }
        static void Main(string[] args)
        {
            //create shape objects
            Shape shape1 = new Circle
            {
                //set radius
                Radius = 5
            };

            Shape shape2 = new Circle
            {
                //set radius
                Radius = 3
            };

            Shape shape3 = new Triangle
            {
                //set base and height
                Base = 4,
                Height = 9
            };

            Shape shape4 = new Triangle
            {
                //set base and height
                Base = 7,
                Height = 2
            };

            Shape shape5 = new Triangle
            {
                //set base and height
                Base = 11,
                Height = 21
            };

            Shape shape6 = new Rectangle
            {
                //set length and width
                Length = 450,
                Width = 17
            };

            Shape shape7 = new Rectangle
            {
                //set length and width
                Length = 40,
                Width = 2
            };

            Shape shape8 = new Rectangle
            {
                //set length and width
                Length = 23,
                Width = 221
            };

            //create list with shapes
            List<Shape> shapes = new List<Shape>() { shape1, shape2, shape3, shape4, shape5, shape6, shape7, shape8 };

            //declare count to output shape number
            int count = 1;

            //output area of each shape
            foreach (Shape shape in shapes)
            {
                //output shape and area
                Console.Write($"The area of shape {count} is: ");
                
                //call method to get area
                shape.CalculateArea();

                //increase count
                count++;
            }
        }
    }
}
