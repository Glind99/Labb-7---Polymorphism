namespace Lab_7___OOP_Polymorphism
{
    class program
    {
        static void Main()
        {

            Circle circle = new Circle(); // Creating a new Circle object with a default constructor.
            Console.WriteLine("Arean på circel med radie 4 = " + circle.Area()); // Calculating and printing the area of the circle with radius 4.
            Console.WriteLine("------------------------------");

            Square square = new Square();  // Creating a new Square object with a default constructor.
            Console.WriteLine("Arean på fyrkant med sida 4 = " + square.Area() + " och omkrets: " + square.circumference()); // Calculating and printing the area and circumference of the square with side length 4.
            Console.WriteLine("------------------------------");

            Parallellogram parallellogram = new Parallellogram();  // Creating a new Parallellogram object with a default constructor.
            Console.WriteLine("Arean på en parallellogram med basen 4 & höjden 5 = " + parallellogram.Area()); // Calculating and printing the area of the parallellogram with base 4 and height 5.
            Console.WriteLine("------------------------------");

            Ellips ellips = new Ellips(); // Creating a new Ellips object with a default constructor.
            Console.WriteLine("Arean på en ellips med sida A = 15 & sida B = 12 = " + ellips.Area());  // Calculating and printing the area of the ellips with side A = 15 and side B = 12.
            Console.WriteLine("------------------------------");

            Rectangle rectangle = new Rectangle(); // Creating a new Rectangle object with a default constructor.
            Console.WriteLine("Arean på en rektangel med basen 15 och höjden 10 = " +  rectangle.Area()); // Calculating and printing the area of the rectangle with base 15 and height 10.
            

        }
    }
 }

