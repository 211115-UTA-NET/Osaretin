using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        // Implement your Square Class here.

        protected override void SetArea()
        {
            //TODO: Real Code
            Rectangle abstr = new Square();
            abstr.Name = "square1";
            abstr.NumSides = 4;

        }
    }
}
