using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the size of Array: ");
        int sizeOfArray = int.Parse(Console.ReadLine());

        Console.Write("Enter elements of Array: ");
        int[] myArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        
        Console.Write("Enter rotate time of Array: ");
        int rotateTime = int.Parse(Console.ReadLine());

        // Handle edge cases
        if (rotateTime > sizeOfArray)
            rotateTime %= sizeOfArray;

        // Create a new array to store the rotated elements
        int[] rotatedArray = new int[sizeOfArray];

        // Perform the rotations and store elements in the rotatedArray
        for (int iteration = 0; iteration < sizeOfArray; iteration++)
        {
            int newPosition = (iteration + rotateTime) % sizeOfArray;
            rotatedArray[newPosition] = myArray[iteration];
        }

        // Output the rotated array
        for (int iteration = 0; iteration < sizeOfArray; iteration++)
        {
            Console.Write(rotatedArray[iteration] + " ");
        }
        Console.WriteLine();
    }
}
