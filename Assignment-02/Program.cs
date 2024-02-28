/*
 1) Write a C# program that takes two numbers as input from the user and performs the following arithmetic operations:
Addition
Subtraction
Multiplication
Division
Modulus (Remainder)
 */

Console.WriteLine("Enter a first number");
var num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a second number");
var num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Addition of two numbers is: {num1 + num2}");
Console.WriteLine($"Subtraction of two numbers is: {num1 - num2}");
Console.WriteLine($"Multiplication of two numbers is: {num1 * num2}");
Console.WriteLine($"Division of two numbers is: {num1 / num2}");
Console.WriteLine($"Modulus of two numbers is: {num1 % num2}");


/*
 2) Write a C# program to compare two numbers entered by the user and print whether the first number is greater than, less than, or equal to the second number.
 */

//Console.WriteLine("Enter a first number");
//var a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter a second number");
//var b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"a = {a} & b = {b}");

//if (a > b)
//{
//    Console.WriteLine($"{a} is greater than {b}");
//}else if (a < b)
//{
//    Console.WriteLine($"{a} is less than {b}");
//}
//else if (a == b)
//{
//    Console.WriteLine($"{a} is equal to {b}");
//}


/*
 3) Write a C# program to print the multiplication table of a number entered by the user using a loop (for, while, or do-while).
 */

//Console.WriteLine("Enter a number to print multiplication table");
//var table = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{table} x {i} = {table * i}");
//}


/*

4) Write a C# program to print a pattern of asterisks (*) in the following format using nested loops:
*
**
***
****
*****

*/


//for (int i = 1; i <= 5; i++)
//{
//   for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}


/*
 5) Write a C# program to find the sum of all even numbers between 1 and 100 using loop control statements (break and continue).
 */

//var sum = 0;

//for(int i = 1; i <= 100; i++)
//{
//    if(i % 2 == 0)
//    {
//        Console.WriteLine(i);

//        sum += i;
//    }
//}

//Console.WriteLine($"Sum of even numbers b/w 1 to 100 is: {sum}");


/*
 6) Write a C# program to reverse a string entered by the user without using any built-in reverse functions or methods.
 */

//Console.WriteLine("Enter a string: ");

//var str = Console.ReadLine();
//string reverse_str = "";

//for (int i = str.Length-1;  i >= 0; i--)
//{
//    reverse_str = reverse_str + str[i];
//}

//Console.WriteLine(reverse_str);


/*
 7) Write a C# program to print all the prime numbers between 1 and 100 using a loop and conditional statements.
 */