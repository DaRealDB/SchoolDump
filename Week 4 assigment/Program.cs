using System;


namespace Week4Assignment
{


    class AccessDemo
    {
        public int publicNumber = 42; // This is a public field, accessible from anywhere.
        private int privateNumber = 17; // This is a private field, only accessible within this class.
        internal int internalNumber = 99; // This is an internal field, accessible within the same assembly.

        // Constructor for initializing the class
        public AccessDemo()
        {
            Console.WriteLine("Constructor: Setting privateNumber to 10");
            privateNumber = 10;
        }

        // Public method that can be called from anywhere
        public void DisplayPublic()
        {
            Console.WriteLine($"Public number: {publicNumber}");
            DisplayPrivate(); // We can call a private method from within the class.
            Console.WriteLine($"Internal number: {internalNumber}");
        }

        // Private method, only accessible within this class
        private void DisplayPrivate()
        {
            Console.WriteLine($"Private number: {privateNumber}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of the 'AccessDemo' class
            AccessDemo demo = new AccessDemo();

            // Call the public method, which can access public and internal fields
            demo.DisplayPublic();


             //Console.WriteLine(demo.privateNumber);   // Private field not accessible from outside the class.
            Console.WriteLine(demo.internalNumber);  // Internal field not accessible from outside the assembly.
        }
    }
}
