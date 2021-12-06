using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        // Implement your Rectangle class here.


        public Rectangle() : base("Rec1", 4)
        {

        }


        protected override void SetArea()
        {
            //TODO: Real Code
            Shape abstr = new Rectangle();
            abstr.Name = "Rec1";
            abstr.NumSides = 4;

        }


       public void retrieveArea()
        {

        }
    }
}
