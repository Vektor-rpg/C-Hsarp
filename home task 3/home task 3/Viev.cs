using System;
using static System.Console;

public static class Viev
{
   public static void Pause()
    {
        ReadKey();
    }
    
    public static void Print( object value)
    {
        WriteLine(value);
    }

    public static string GetString()
    {
        return Console.ReadLine();
    }

    public static int GetInt()
    {
        return Int32.Parse(GetString());
    }

    public static Double GetDouble()
    {
        return Double.Parse(GetString().Replace ('.', ','));
    }
}
