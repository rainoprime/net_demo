using System;
using System.IO.Pipes;


public class Program_2
{
    public static void Main()
    {
        string[] names = new string[8];
        names[0] = "B123";
        names[1] = "C234";
        names[2] = "A345";
        names[3] = "C15";
        names[4] = "B177";
        names[5] = "G3003";
        names[6] = "C235";
        names[7] = "B179";

        foreach (string name in names)
        {
            if (name.StartsWith("B")) 
            {
                Console.WriteLine(name);
            }

        }


    }
}