using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {

            byte myByte = 100;

            sbyte mySbyte = 50;

            int myInt = 1000;

            uint myUint = 43292;

            short myShort = 23200;

            ushort myUShort = 100;

            float myFloat = 23999992;

            double myDouble = 232.234;

            char myCharacter = 'd';

            bool myBool = true;

            string myText = "dfgdgdfgdfgdfgfdgdfgdffdgdfdggd";

            string numText = "100";


            string val1 = "I control text";
            string val2 = "50";

            Console.WriteLine(val1);
            Console.WriteLine(Text2Num(val2));


        }



        public static int Text2Num(string numText)
        {
            try
            {
                int number = 0;

                int.TryParse(numText, out number);

                // Console.WriteLine(successfullyParsed);
                return number;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }
    }
}
