//Task 10

const int numberOfnumbers = 6;
var numbers = new int[numberOfnumbers];

for (var i = 0; i < numbers.Length; i++)
{
    Console.WriteLine($"Enter the number {i+1}");
    numbers[i] = int.Parse(Console.ReadLine());
}

var sum = 0;
for (var i = 0; i < numbers.Length; i++)
    sum += numbers[i];

var average = 1.0 * sum / numberOfnumbers;
Console.WriteLine($"The sum is {sum} and average is {average}");

//a
//Console.WriteLine("Enter the first number");
//int number1 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the second number");
//int number2 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the third number");
//int number3 = int.Parse(Console.ReadLine());

//Console.WriteLine("Enter the fourth number");
//int number4 = int.Parse(Console.ReadLine());

//int sum = number1 + number2 + number3 + number4;
//double average = sum / 4.0;

//Console.WriteLine($"The sum is {sum} and average is {average}");


//Task 8
//Console.WriteLine("Enter the lenght of side a");
//double a = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the lenght of side b");
//double b = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter the lenght of side c");
//double c = double.Parse(Console.ReadLine());

//double perimeter = a + b + c;

//double p = perimeter / 2;
//double area = Math.Sqrt(p * (p - a) * (p - b) *  (p - c));

//Console.WriteLine($"The area is {area} and perimeter is {perimeter}");



//Task 6 - Homework

//Task 5
//Console.WriteLine("Enter the radius of the circle");
//double radius = double.Parse(Console.ReadLine());
//double area = Math.PI * radius * radius;
//Console.WriteLine($"The area is {area}");


//Task4
//Console.WriteLine("What is your name?");

//string name = Console.ReadLine();
//Console.WriteLine($"Hello {name}");


//Task 3
//d
//string name = "Marcin";
//Console.WriteLine($"Hello {name}");

//c
//Console.WriteLine(string.Format("Hello {0}", name));

//b
//Console.WriteLine("Hello " + name);

//a
//Console.Write("Hello ");
//Console.WriteLine(name);

//Task 2
//string name = "Marcin";
//Console.WriteLine(name);

//Task 1
//Console.WriteLine("Hello");
