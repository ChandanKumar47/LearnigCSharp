// Problem Statement :- 

// Design a class named Box whose dimensions are integers and private to the class.

// The dimensions are labelled: length, breadth and height.

//     The default constructor of the class should initialize them to 0 (ZERO).
//     The parameterized constructor Box(int length, int breadth, int height) should initialize them to length, breadth and height respectively.
//     The copy constructor Box(Box b1) should set them to b1's length, breadth and height respectively.

// Apart from the above, the class should have  functions:

//     int getLength() - Return box's length
//     int getBreadth() - Return box's breadth
//     int getHeight() - Return box's height
//     long long CalculateVolume() - Return the volume of the box

using System;

namespace PracticeCSharp
{   
    class Box {
        private int length, breadth, height;
        Box (this.lenght, this.breadth,height){
            this.lenght = lenght;
            this.breadth= breadth;
            this.height= height;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my Second Program Program !");
        }
    }
}