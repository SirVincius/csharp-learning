using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

public enum ConsoleColor
{
    Black,      // 0
    DarkBlue,   // 1
    DarkGreen,  // 2
    DarkCyan,   // 3
    DarkRed,    // 4
    DarkMagenta,// 5
    DarkYellow, // 6
    Gray,       // 7
    DarkGray,   // 8
    Blue,       // 9
    Green,      // 10
    Cyan,       // 11
    Red,        // 12
    Magenta,    // 13
    Yellow,     // 14
    White       // 15
}

enum Slime
{
    BlueSlime = 10,
    GreenSlime,
    RedSlime
}


struct Point {
    public int coordx;
    public int coordy;

    public void printX()
    {
        Console.WriteLine("x = {0}", coordx);
    }
}

class Program
{

    public static void printArray<T>(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == null)
                Console.WriteLine("Item {0} == null", i + 1);
            else
                Console.WriteLine("Item #{0} = {1}", i + 1, array[i].ToString());
        }
    }

    public static int addMultipleInt(params int[] multipleInts)
    {
        int sum = 0;
        foreach (int i in multipleInts)
        {
            sum += i;
        }
        return sum;
    }
    //LOCAL FUNCTION TESTING
    public static string localFunctionTest1()
    {
        string getName()
        {
            return "Brunelle";
        }

        return "Vincent " + getName();
    }

    public static void incrementInt(int value)
    {
        value++;
    }

    public static void AssignSomeValues(int x, string s, out int intValue, out string stringValue)
    {
        intValue = x;
        stringValue = new string(s);
    }

    public static int substract(int value1, int value2)
    {
        return value1 - value2;
    }
    public static void Main()
    {
        //INT different type of declaration and initialization
        int int1;
        int int2 = 2;
        int int3, int4, int5;
        int int6 = 6, int7 = 7, int8 = 8;

        int1 = 1;
        int3 = 3;
        int4 = 4;
        int5 = 5;

        List<int> ints = new List<int> { int1, int2, int3, int4, int5, int6, int7, int8 };
        Console.WriteLine("** Printing numbers from 1 to 8 **\n");
        foreach (int i in ints)
        {
            Console.Write($"{i} ");
        }
        Console.WriteLine("\n");
        Console.WriteLine($"INT type max value = {Int32.MaxValue}");
        Console.WriteLine($"INT type min value = {Int32.MinValue}");
        Console.WriteLine("\n");

        /*
        Console.Write("Enter a whole number then press enter : ");
        int number1;
        if (Int32.TryParse(Console.ReadLine(), out number1))
            Console.WriteLine("Number is {0}", number1);
        else
            Console.WriteLine("Input is not a valid int");
        Console.WriteLine("");
        */

        //DATETIME
        DateTime datetime1;
        datetime1 = new DateTime(1985, 01, 28);
        Console.WriteLine(datetime1.ToString());
        // atetime1.Add(new TimeSpan(0, 6, 0)); -> Does not modify the datetime because
        // it is an immutable struct, the result must be assigned, it now points to a
        // new Datetime object
        // TODO : READ MORE ABOUT MUTABLE VS IMMUTABLE
        datetime1 = datetime1.Add(new TimeSpan(0, 6, 0));
        Console.WriteLine(datetime1.ToString());
        Console.WriteLine("");

        //DIGIT SEPARATOR
        Console.WriteLine("** Digit separator **");
        Console.WriteLine("You can't see the digit separator '_' in 514_123_456.");
        Console.WriteLine(514_123_456);
        Console.WriteLine("");

        //STRING MANIPULATION
        string string1;
        string string2 = new string("Strawberry");
        string string3, string4, string5;
        string1 = new string("Raspberry");
        string3 = new string("Banana");
        string4 = string5 = string3;
        string[] strings = { string1, string2, string3, string4, string5 };
        int count = 1;
        foreach (string s in strings)
        {
            Console.WriteLine($"String #{count} : {s}");
            count++;
        }
        count = 1;
        Console.WriteLine("");
        string3 = new string("Apple");

        // ARRAY KEEPS POINTING TO THE REFERENCE VALUE, NOT THE REFERENCE ITSELF
        Console.WriteLine(string3);
        foreach (string s in strings)
        {
            Console.WriteLine($"String #{count} : {s}");
            count++;
        }

        // WHAT ABOUT ARRAY OF VALUES?
        int[] intArr = { int1, int2, int3, int4, int5 };
        for (int i = 0; i < intArr.Length; i++)
        {
            Console.WriteLine($"Int#{i} = {intArr[i]}");
        }
        int1 = 10;
        Console.WriteLine($"Int#1 = {int1}");
        for (int i = 0; i < intArr.Length; i++)
        {
            Console.WriteLine($"Int#{i} = {intArr[i]}");
        }
        // ARRAY KEEPS A COPY OF THE VALUE, THEY ARE NOT LINKED TO THE VARIABLE'S VALUE

        //BACK TO STRING MANIPULATION
        Console.WriteLine("");
        Console.WriteLine($"String1 = String5 : {string1.Equals(string5)}");
        Console.WriteLine($"String4 = String5 : {string4.Equals(string5)}");

        string string6 = new string("Ban");
        Console.WriteLine($"String1 contains String5 : {string1.Contains(string5)}");
        Console.WriteLine($"String4 contains String5 : {string4.Contains(string5)}");
        Console.WriteLine($"String4 contains String6 : {string4.Contains(string6)}");
        string[] rasSplit = string1.Split("ber"); //Delete "ber" and return string from both side
        foreach (string s in rasSplit)
        {
            Console.WriteLine(s);
        }
        string multOf = "Greatest hero of the 'Mountain of Courage' of all time.";
        //Delete every "of" and return every string before "of", after "of", or in-between 2 "of".
        string[] multOfSplit = multOf.Split("of");
        foreach (string s in multOfSplit)
        {
            Console.WriteLine(s);
        }
        Console.WriteLine(string6.PadLeft(10));

        Console.WriteLine("=> Immutable Strings 2:\a");
        string s2 = "My other string";
        s2 = "New string value";
        Console.WriteLine(s2);
        Console.WriteLine("");

        //IMPLICITLY TYPED VARIABLE
        var someInt = 10;
        var someString = "Hello";
        // Below types are defined automatically (only for local variables,
        // it must be initialized, it must not be null
        Console.WriteLine($"someInt type : {someInt.GetType().Name}");
        Console.WriteLine($"someString type : {someString.GetType().Name}");

        int switch1 = 3;

        // SWITCH
        switch (switch1)
        {
            case 1:
                Console.WriteLine("1");
                break;
            case 2:
                Console.WriteLine("2");
                break;
            case int i: // Pattern matching, if it is an int, then i contains the value
                {
                    Console.WriteLine("i = " + i);
                    Console.WriteLine("i = " + i); // Multiple statements allowed
                }
                break;
            default:
                Console.WriteLine("Other");
                break;
                // 1-955-4-6, 1-325-5-0, 1-835-1-5
        }

        //ARRAY
        int[] ints2 = { 3, 4, 5, 1, 2 };
        Console.WriteLine($"Printing {nameof(ints2)} array");
        printArray<int>(ints2);

        int[] ints3 = new int[ints2.Length];
        ints2.CopyTo(ints3, 0);
        Console.WriteLine($"Printing {nameof(ints3)} array");
        printArray<int>(ints3);
        Array.Sort(ints3);
        Array.Reverse(ints3);
        Console.WriteLine($"Printing {nameof(ints3)} array ordered and reversed.");
        printArray<int>(ints3);
        Console.WriteLine($"Printing {nameof(ints3)} first 3 elements.");
        foreach (var item in ints3[0..3])
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Printing {nameof(ints3)} first 3 elements.");
        Range range = 0..3;
        foreach (var item in ints3[range])
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Printing {nameof(ints3)} first 3 elements.");
        int r1 = 0;
        int r2 = 3;
        range = r1..r2;
        foreach (var item in ints3[range])
        {
            Console.WriteLine(item);
        }
        //TESTING LOCAL FUNCTION
        Console.WriteLine(localFunctionTest1());
        int someValue1 = 1;
        incrementInt(someValue1);
        Console.WriteLine(someValue1);

        int[] ints4 = { 1, 2, 3, 4, 5 };
        Console.WriteLine(addMultipleInt(ints4));
        Console.WriteLine(substract(5, 2));
        Console.WriteLine(substract(value2: 5, value1: 2));

        //ENUM
        Slime redSlime = Slime.RedSlime;
        Console.WriteLine(redSlime);
        Console.WriteLine((int)redSlime);
        Console.WriteLine((Slime)11);
        Console.WriteLine("redSlime is a {0}", redSlime.ToString());
        Array slimeValues = Enum.GetValues(typeof(Slime));
        foreach (Slime s in slimeValues)
        {
            Console.WriteLine("Name = {0}", s);
            Console.WriteLine("Value = {0}", (int)s);
        }

        //STRUCTURE
        Point point1;
        point1.coordx = 5;
        point1.coordy = 10;
        point1.printX();

    }
}