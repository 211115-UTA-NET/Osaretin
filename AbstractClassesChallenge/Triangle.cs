using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        // Implement your Triangle class here.
        // HINT: Use Herons Formula to calculate and set the area.
        public Triangle() : base("triangle", 3)
        {

        }


        protected override void SetArea()
        {
            //TODO: Real Code
            Shape abstr = new Rectangle();
            abstr.Name = "triangle";
            abstr.NumSides = 3;

            abstr.GetArea = 34;

        }
    }
}
