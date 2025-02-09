using System;
using System.Collections.Generic;

public class Program
{
    public static string OldPhonePad(string input)
    {
        var keypad = new Dictionary<char, string>
        {
            {'1',"&'(" },{'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"}, {'5', "JKL"},
            {'6', "MNO"}, {'7', "PQRS"}, {'8', "TUV"}, {'9', "WXYZ"},
            {'0', " "}
        };

        string result = "";
        char lastKey = '\0'; 
        int count = 0;         

        foreach (char key in input)
        {
            if(lastKey == key)
            {
                count++;
            } 
            else if (key == '*')
            { 
                 if (result.Length > 0)
                 {
                    result = result.Substring(0, result.Length );
                    count = 0;
                    lastKey = '\0';  
                 }
                continue;
            }
            else if (key == '#')
            {
                break;
            }
            else
            {
                if (lastKey != '\0' && keypad.ContainsKey(lastKey))
                {
                    string group = keypad[lastKey];
                    result += group[(count - 1) % group.Length];  
                }

                lastKey = key;
                count = 1;  
            }
        }

        if (lastKey != '\0' && keypad.ContainsKey(lastKey))
        {
            string group = keypad[lastKey];
            result += group[(count - 1) % group.Length];
        }


        return result;
    }

    public static void Main(string[] args)
    {
        string result = OldPhonePad("557***#");
        Console.WriteLine(result);

    }
}
