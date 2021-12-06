using System;

namespace AbstractClassesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Rectangle rec = new Rectangle();
            Square squ = new Square();
            Triangle tri = new Triangle();


            rec.GetInfo();
            squ.GetInfo();
            tri.GetInfo();

            //did not have time to calculate area

        }
    }
}
