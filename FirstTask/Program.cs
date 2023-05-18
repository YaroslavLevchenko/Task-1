using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    interface IShape //task 1
    {
        int SideOfTheSquare { get; set; }
        int GettingArea();
        int GettingPerimeter();

    }

    class Shape : IShape
    {
        private int sideOfTheSquare;
        private int area;
        private int perimeter;

        public int SideOfTheSquare
        {
            get => sideOfTheSquare;
            set => sideOfTheSquare = value;
        }

        public int GettingArea()
        {
            area = sideOfTheSquare * sideOfTheSquare;
            return area;
        }
        public int GettingPerimeter()
        {
            perimeter = sideOfTheSquare * 4;
            return perimeter;
        }

    }
    class Info // Task 2
    {
        private string name { get; set; }
        private int age { get; set; }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int Age
        {
            get => age;
            set => age = value;
        }

    }

    class Circle // Task 3
    {
        private double r { get; set; }
        private double l { get; set; }
        private double a { get; set; }
        private double v { get; set; }


        public double R
        {
            get => r;
            set => r = value;
        }


        public double GettingLength()
        {
            l = 2 * Math.PI * r;
            return l;
        }

        public double GettingArea()
        {
            a = Math.PI * r * r;
            return a;
        }

        public double GettingVolume()
        {
            v = 4 / 3 * Math.PI * Math.Pow(r, 3);
            return v;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            Shape shape = new Shape();
            Console.WriteLine("Please indicate the side of a square: ");
            shape.SideOfTheSquare = int.Parse(Console.ReadLine());
            Console.WriteLine("Here is the Area:" + " " + $"{shape.GettingArea()}");
            Console.WriteLine("Here is the Perimeter:" + " " + $"{shape.GettingPerimeter()}");

            //task 2
            Info info = new Info();
            Console.WriteLine("What is your name: ");
            info.Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("How old are you?", info.Name);
            info.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(info.Name + " " + info.Age);

            //task 3
            Circle circle = new Circle();
            Console.WriteLine("Type the radius of a circle:");
            circle.R = double.Parse(Console.ReadLine());
            Console.WriteLine("The length of a circle:" + " " + $"{circle.GettingLength()}");
            Console.WriteLine("The area of a circle:" + " " + $"{circle.GettingArea()}");
            Console.WriteLine("The volume of a circle:" + " " + $"{circle.GettingVolume()}");
            Console.ReadKey();
        }
    }
}
