using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_11_Project_1
{
    interface IShape
    {
        int CalculatePerimeter();
        int CalculateArea();
    }

    class Circle : IShape
    {
        private int radius;

        public void Readradius()
        {
            Console.WriteLine("Enter radius");
            radius = Convert.ToInt32(Console.ReadLine());
            
        }
        public int CalculateArea()
        {
            return 22*radius*radius/7;
        }

        public int CalculatePerimeter()
        {
            return 2*22*radius/7;
        }
    }


    class Square : IShape
    {
        int side;
        public void Readside()
        {
            Console.WriteLine("Enter side");
            side = Convert.ToInt32(Console.ReadLine());
        }

        public int CalculateArea()
        {
            return side*side;
        }

        public int CalculatePerimeter()
        {
            return 4*side;
        }
    }


    class Triangle : IShape
    {
        private int a;
        private int b;
        private int c;



        public void Readdata()
        {
            Console.WriteLine("enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public int CalculateArea()
        {
            return a * b * c;
        }

        public int CalculatePerimeter()
        {
            return a + b + c;
        }

    }

        class Rectangle : IShape
        {
            private int l;
            private int b;

           

            public void Readdata()
            {
                Console.WriteLine("enter l");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter b");
                b = Convert.ToInt32(Console.ReadLine());
            }

            public int CalculateArea()
            {
                return l*b;
            }

            public int CalculatePerimeter()
            {
                return 2*(l+b);
            }


        }


    
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.Readradius();
            Console.WriteLine(cir.CalculatePerimeter());
            Console.WriteLine(cir.CalculateArea());


            Square sqr = new Square();
            sqr.Readside();
            Console.WriteLine(sqr.CalculatePerimeter());
            Console.WriteLine(sqr.CalculateArea ());


            Triangle tri = new Triangle();
            tri.Readdata();
            Console.WriteLine(tri.CalculateArea ());
            Console.WriteLine(tri.CalculatePerimeter());



            Rectangle rec = new Rectangle();

            rec.Readdata();
            Console.WriteLine(rec.CalculateArea());
            Console.WriteLine(rec.CalculatePerimeter());


            Console.ReadLine();




        }
    }

   
}
