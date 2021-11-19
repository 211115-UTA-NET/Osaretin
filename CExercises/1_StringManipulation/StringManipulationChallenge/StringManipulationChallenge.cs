using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;

            //
            //
            //implement the required code here and within the methods below.
            //
            //


            string strVar;
            int intVar;

            Console.WriteLine("Please enter your message and press enter");
            strVar = Console.ReadLine();


            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            intVar = int.Parse(Console.ReadLine());

            Console.WriteLine("Uppercase "+StringToUpper(strVar));
            Console.WriteLine("Lowercase  " + StringToLower(strVar));
            Console.WriteLine("Trim " + StringTrim(strVar));

            Console.WriteLine("String lenght " + StringSubstring(strVar, intVar));

            char charVar;
            Console.WriteLine("For which character should I search in your original message?");


            string input = Console.ReadLine();
            charVar = input[0];

             
            Console.WriteLine("index at " + SearchChar(strVar, charVar));


            Console.WriteLine("Enter First Name");
             fName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
             lName = Console.ReadLine();

            Console.WriteLine("Concat " + ConcatNames(fName, lName));
           

        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x)
        {
            try
            {
                return x.ToUpper();
            }
            catch
            {
                throw new NotImplementedException("StringToUpper method not implemented.");
            }
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x)
        {

            try
            {

                return x.ToLower();
            }
            catch
            {
                throw new NotImplementedException("StringToUpper method not implemented.");
            }
        }

        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x)
        {

            try
            {

                return x.Trim();
            }
            catch
            {
                throw new NotImplementedException("StringTrim method not implemented.");
            }
        }

        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum)
        {
            try
            {
                int len = x.Length;
                return len.ToString();
            }
            catch
            {
                throw new NotImplementedException("StringSubstring method not implemented.");
            }
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x)
        {
            try
            {
                int indx = userInputString.IndexOf(x);

                return indx;
            }
            catch
            {
                throw new NotImplementedException("SearchChar method not implemented.");
            }
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName)
        {

            try
            {
                return fName + " " + lName;
            }
            catch
            {
                throw new NotImplementedException("ConcatNames method not implemented.");
            }
        }



    }//end of program
}
