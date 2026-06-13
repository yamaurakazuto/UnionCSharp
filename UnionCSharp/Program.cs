using System;   
public record class Success(string Message);
public record class Error(string Message);

public union Result(Success, Error);

public class Program
{
    public static void Main()
    {
        Result result = new Success("保存成功");

        string message = result switch
        {
            Success(var msg) => $"OK: {msg}",
            Error(var msg) => $"NG: {msg}"
        };

        Console.WriteLine(message);
    }
}