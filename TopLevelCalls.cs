using NewFeaturesCSharp;
using System;
string sentence = "Top Level Calls";
PrintSentense(sentence);
PrintDouble(20.2);


static void PrintSentense(string sentence)
{
    Console.WriteLine(sentence);
}

static void PrintDouble(double value)
{
    Console.WriteLine(value);
}

/*
// You can create a classe, enum and struct under the code, but it is not usual
class MyClass
{
    public string MyClassName { get; set; }
}
*/