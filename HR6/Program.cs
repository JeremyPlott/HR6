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

class Solution {

    // Complete the pangrams function below.
    static string pangrams(string s) {

        s = s.ToLower();

        bool hasLetter = s.Contains("a") &&
            s.Contains("b") &&
            s.Contains("c") &&
            s.Contains("d") &&
            s.Contains("e") &&
            s.Contains("f") &&
            s.Contains("g") &&
            s.Contains("h") &&
            s.Contains("i") &&
            s.Contains("j") &&
            s.Contains("k") &&
            s.Contains("l") &&
            s.Contains("m") &&
            s.Contains("n") &&
            s.Contains("o") &&
            s.Contains("p") &&
            s.Contains("q") &&
            s.Contains("r") &&
            s.Contains("s") &&
            s.Contains("t") &&
            s.Contains("u") &&
            s.Contains("v") &&
            s.Contains("w") &&
            s.Contains("x") &&
            s.Contains("y") &&
            s.Contains("z");

        if (hasLetter) {
            return "pangram";
        }
        else {
            return "not pangram";
        }
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = pangrams(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
