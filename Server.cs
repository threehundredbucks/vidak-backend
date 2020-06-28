using System;
using System.Diagnostics;
using vidak_backend;

public class Server
{

    public static void Write(string s)
    {
        Console.WriteLine(s);
    }

    public static void Write(bool b)
    {
        Console.WriteLine(b);
          
    }

    static void Main()
    {
        string name = "Scott";
        System.Diagnostics.Debug.WriteLine($"Hello, {name}");
        var uc = new UniversalClass();
        uc.DoMath();
    }
}