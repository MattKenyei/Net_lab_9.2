using System;

class MyClass
{
    // Пример метода без аргументов
    public void MethodWithoutArguments()
    {
        Console.WriteLine("This is a method without arguments.");
    }

    // Пример метода с аргументами разных типов
    public void MethodWithArguments(int number, string text, bool flag)
    {
        Console.WriteLine("This is a method with arguments:");
        Console.WriteLine("Number: " + number);
        Console.WriteLine("Text: " + text);
        Console.WriteLine("Flag: " + flag);
    }
    public void MethodWithoneArgument(decimal number)
    {
        Console.WriteLine("This is a method with one argument: \nNumber: " + number);
    }
}