Console.WriteLine();
Console.WriteLine("This console application calculates 'Sum of Array'");
Console.WriteLine();

Console.Write("Enter the size of Array: ");
int sizeOfArray = int.Parse(Console.ReadLine());
int sumOfArray = 0;

int[] myArray = new int[sizeOfArray];

for(int iteration = 0; iteration < sizeOfArray; iteration++)
{
    Console.Write($"myArray[{iteration}] = ");
    myArray[iteration] = int.Parse(Console.ReadLine());
}

Console.Write("Elements of myArray: ");

for(int iteration = 0; iteration < sizeOfArray; iteration++)
{
    Console.Write($"{myArray[iteration]} ");
}

Console.WriteLine();

for(int iteration = 0; iteration < sizeOfArray; iteration++)
{
    sumOfArray += myArray[iteration];
}

Console.WriteLine($"sumOfArray = {sumOfArray}");
