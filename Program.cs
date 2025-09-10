using System;

namespace ClassActivity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Density Calculator");
            
            Console.Write("Enter the mass of the object (in kilograms): ");
            double mass = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the volume of the object (in cubic meters): ");
            double volume = Convert.ToDouble(Console.ReadLine());

            if (volume == 0)
            {
                Console.WriteLine("Error: Volume cannot be zero.");
            }
            else
            {
                double density = mass / volume;
                Console.WriteLine($"The density of the object is: {density} kg/m³");
            }
        }
    }
}
