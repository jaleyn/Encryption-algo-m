using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'encryption' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string encryption(string s)
    {
         s = s.Replace(" ", ""); 
        int L = s.Length;
        int rows = (int)Math.Floor(Math.Sqrt(L));
        int cols = (int)Math.Ceiling(Math.Sqrt(L));

        if (rows * cols < L)
            rows++;

        StringBuilder sb = new StringBuilder();

        for (int c = 0; c < cols; c++)
        {
            if (c > 0) sb.Append(' ');

            for (int r = 0; r < rows; r++)
            {
                int index = r * cols + c;
                if (index < L)
                    sb.Append(s[index]);
            }
        }

        return sb.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.encryption(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
