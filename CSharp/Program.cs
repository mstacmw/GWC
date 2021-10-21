//loosely stolen from tutorialspoint.com

//using keyword is used to include namespaces
using System;

//use namespace to declare a namespace
//this is required for the code to run
namespace CSharp
{
    //use class to declare a class
    class Rectangle {
      
      // declare variables with or without a value
      //class variables are automatically private. Make them public by using the public keyword
      public double length;
      public double width;
      public String name;
      public bool square = false;
      
      //declare functions as below. Functions can have parameters
      public void isSquare() {
          //declare if statements as below
          //operators are identical to C++
          //parentheses around condition are required
          if (length == width) {
              square = true;
            //no elif keyword like python
          } else if (length != width) {
              square = false;
          } else {
              //output messages to screen using the console.writeline() function
              //no cout like c++ or print() like python
              Console.WriteLine("Something went wrong...");
          }
      }
      public double GetArea() {
         return length * width; 
      }

      public double GetLongArea() {
          Double area51 = 0;
          Double area52 = 0;
          int i = 0;
          //use the while keyword for while loops
          while (i < length) {
              // operator= commands work in c#
              area51 += width;
              //as do ++ commands
              i++;
          }
          //use the for keyword for for loops
          for(int j = 0; j < length; j++){
              area52 += width;
          }
          if (area51 != area52){
              return -1;
          }
          return area51;

      }
      public void Display() {
         //using variables or functions in print statements requires {0}
         Console.WriteLine();
         Console.WriteLine(name);
         Console.WriteLine("Length: {0}", length);
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
         Console.WriteLine("Area the Long Way: ", GetLongArea());
         Console.WriteLine("Square: {0}", square);
      }
    }

    //the class containing Main is required for the code to run.
    class Program
    {
        //Main() must always be included. Syntax is generally as given
        static void Main(string[] args)
        {
            //use a class object by using the new keyword
            Rectangle r = new Rectangle();
            Console.WriteLine("Name your rectangle: ");
            //obtain user input using the ReadLine() function
            r.name = Console.ReadLine();
            Console.WriteLine("Enter the length, then width: ");
            //readline() always returns a string. Must type cast for other types
            r.length = Convert.ToDouble(Console.ReadLine());
            r.width = Convert.ToDouble(Console.ReadLine());
            r.Display();
        }
    }
}
