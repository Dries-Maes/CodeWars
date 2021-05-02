using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    private static void Main(string[] args)
    {
        // Laten staan, heeft hij nodig.
    }

    public static string ExpandedForm(long num)
    {
        string charArray = num.ToString();
        string output = "";
        for (int i = 0; i < charArray.Length; i++)
        {
            if (charArray[i] != '0')
            {
                if (i > 0)
                {
                    output += " + ";
                }

                string nullen = new String('0', charArray.Length - 1 - i);

                output += String.Concat(charArray[i], nullen);
            }
        }
        return output;
    }
}