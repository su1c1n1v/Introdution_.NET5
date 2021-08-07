using NewFeaturesCSharp;
using System;
string sentence = "Top Level Calls";
ClassFeature classFeature;
RecordFeature recordFeature;

classFeature = new("name", 1);
recordFeature = new("name",2);
PrintSentense(sentence);
PrintDouble(20.2);
Console.WriteLine($"Class: {classFeature}");
Console.WriteLine($"Record: {recordFeature}");
var (name, id) = recordFeature;


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