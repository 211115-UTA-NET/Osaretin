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

             conStrToInt(val1, val2);

        
        }


        public static void conStrToInt(string val1, string val2)
        {
            int number = Int32.Parse(val2);

            bool successfullyParsed = int.TryParse(val1, out number);

            Console.WriteLine(successfullyParsed);
        }

      public static int Text2Num(string numText)
      {
        throw new NotImplementedException();
      }
    }
}
