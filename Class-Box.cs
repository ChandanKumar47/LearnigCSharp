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
        //Parametric Constructor
        Box (int lenght,int breadth,int height){
            this.lenght = lenght;
            this.breadth= breadth;
            this.height= height;
        }
        
        // Copy Constructor
        Box (Box obj1){
            this.lenght = obj1.lenght;
            this.breadth = obj1.breadth;
            this.height = obj.height;
        }
        
        Public long long int Volume(){
        return (this.lenght*this*breadth*this.height);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length, Breadth and Height of the Box");
            int lenght = Convert.ToDouble(Console.ReadLine());
            int breadth = Convert.ToDouble(Console.ReadLine());
            int height = Convert.ToDouble(Console.ReadLine());
            Box box = new Box(lenght,breadth,height);
            Console.WriteLine(box.volume);
            
        }
    }
}
