// See https://aka.ms/new-console-template for more information
using System.Data;
using System;
using System.IO;
using System.Collections;


Console.WriteLine("Enter expresssion (Example 2+3+4)|Type load to read from file |type exit to quit");

string ans="";

ArrayList save2File = new ArrayList();

Boolean Exit = false;
while (Exit == false)
{

    string userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        Exit = true;
        Console.WriteLine("Goodbye");
    }
    else if(userInput == "load")
    {
        userInput = FindReplace(load());
        save2File.Add(userInput);
        ans = new DataTable().Compute(userInput, null).ToString();
        save2File.Add(ans);
        Console.WriteLine("Your anwser is " + ans);

        Console.WriteLine("Enter  another expression or type exit to exit");
    }
    else
    {
        save2File.Add(userInput);
        userInput = FindReplace(userInput);
        ans = new DataTable().Compute(userInput, null).ToString();
        save2File.Add(ans);
        Console.WriteLine("Your anwser is " + ans);

        Console.WriteLine("Enter  another expression or type exit to exit");
    }

    save();

}



string FindReplace(string input)
{

    string[] find = { "Plus", "Minus","times","devide","One","two","three","four","five","six","seven","eight","nine","ten" };
    string[] replace = { "+", "-", "*","/","1","2","3","4","5","6","7","8","9","10" };

    for (int i = 0; i < find.Length; i++)
    {
        int Place = input.IndexOf(find[i], StringComparison.CurrentCultureIgnoreCase); //ignore case
        if (Place != -1)
        {
            input = input.Remove(Place, find[i].Length).Insert(Place, replace[i]);
            i--;
        }

    }

    return input;
}


void save()
{
    string path = "./saveFile.txt";
     File.WriteAllLines(path, save2File.Cast<string>());
}


string load()
{
    string path = "./loadFile.txt";
    string text = "";
     StreamReader reader = new StreamReader(path);
     while(reader.Peek() != -1)
     {
        text = reader.ReadToEnd();

        Console.WriteLine(text);
     }
     reader.Close();

    return text;

}