// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

abstract class BaseClass
{
    public abstract string Message { get; set; }
    public abstract char this[int index] { get; set; }
}

class TaskClass : BaseClass
{
    public override char this[int index] 
    { 
        get => Message[index]; 
        set => Message[index] = value; 
    }

    public override string Message { get; set; }
}