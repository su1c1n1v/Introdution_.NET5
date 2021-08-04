# Introduction CSharp 9.0 and .NET 5.0
---

## Goals
- Show the new feateured added in the .NET 5.0;

---
## CSharp 9.0 and .NET 5.0

### Top level call

```C# 
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
```

- The methods don't required to be in a class or a namespace;
- The file with top level call is assumed that the file is the entry point of the application (Main);
- The method inside can not have modifiers (private or public), only works inside the local area;
- It is possible to add a class (under the code);
- The application can only have one top level calls;

### Initial Setter

- It is only allowed to change the propriety when the object is created or inside of the class's construct (read-only);

```C# 
public class InitialSetter
{
    //The propeties can use the init or set
    public int Id { get; init; }
    public string Name { get; set; }

    public InitialSetter(int id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}
```

### Shortening Way to Create an Object

```C# 
// Differente ways to create a object
InitialSetter OBJ = new InitialSetter(1,"name");
InitialSetter OBJ2 = new(2,"name");
var OBJ3 = new InitialSetter(3,"name");

// Incorrect way to create a object
var OBJ3 = new(4,"name");
```

- It is possible to create an object only with the "new()";
- It is necessary to declarety the object with the type, it is not allowed to create an object with the "var" and the "new()"; 

---

### Records

- It is a reference types but acts like a value type;
- It is a class with extra (read-only class);
- The values can not be change (immutable);
- When it is needed to change the values, it is necessary to create a new record;