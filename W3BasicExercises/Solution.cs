using System;

namespace W3BasicExercises
{
    public class W3BasicExercises
    {
        public static void Solution()
        {
            //Console.WriteLine("hello Michelle!");

            //Console.WriteLine(2 + 2);

           // Console.WriteLine(8 / 2);

            // Console.WriteLine(-1 + 4 * 6);
            // Console.WriteLine(( 35+ 5 ) % 7);
            // Console.WriteLine(14 + -4 * 6 / 11);
            // Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            
            //swap numbers c#
            // Console.WriteLine("What is your number?");
            // string userInput1 = Console.ReadLine();
            // int input1 = Int32.Parse(userInput1);
            // Console.WriteLine("What is your second number?");
            // string userInput2 = Console.ReadLine();
            // int input2 = Int32.Parse(userInput2);
            // Console.WriteLine($"Before swap input1 is {input1} and input2 is {input2}");
            //
            // input1 = input1 * input2;
            // input2 = input1 / input2;
            // input1 = input1 / input2;
            // Console.WriteLine($"After swap input 1 is {input1} and input 2 is {input2}");
            
            
            //Multiply three numbers
            // int num1, num2, num3;
            // Console.WriteLine("what is your first number?");
            // num1 = int.Parse(Console.ReadLine());
            // Console.WriteLine("What is your second number?");
            // num2 = int.Parse(Console.ReadLine());
            // Console.WriteLine("What is your third number?");
            // num3 = int.Parse(Console.ReadLine());
            //
            // int result = num1 * num2 * num3;
            //
            // Console.WriteLine(result);

            
            //7. add subtract multiply divide 2 numbers
            // int num1, num2;
            // Console.WriteLine("Input first number");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("input second number");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // int add = num1 + num2;
            // int minus = num1 - num2;
            // int times = num1 * num2;
            // int divide = num1 / num2;
            // int mod = num1 % num2;
            //
            // Console.WriteLine($"{num1} + {num2} = {add}");
            // Console.WriteLine($"{num1} - {num2} = {minus}");
            // Console.WriteLine($"{num1} * {num2} = {times}");
            // Console.WriteLine($"{num1} / {num2} = {divide}");
            // Console.WriteLine($"{num1} % {num2} = {mod}");
            
         
            //8. Write a C# Sharp program that takes a number as input and print its multiplication table.
            // int num;
            // Console.WriteLine("Input multiplication table number");
            // num = Convert.ToInt32(Console.ReadLine());
            // int i;
            // for (i = 0; i <= 10; i++)
            // {
            //     int result = num * i;
            //     Console.WriteLine($"{num} * {i} = {result}");
            // }
            
            
            //9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.
            // int num1, num2, num3, num4;
            // int avg;
            // Console.WriteLine("input number 1");
            // num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("input number 2");
            // num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("input number 3");
            // num3 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("input number 4");
            // num4 = Convert.ToInt32(Console.ReadLine());
            //
            // avg = (num1 + num2 + num3 + num4) / 4;
            //
            // Console.WriteLine($"The average of {num1}, {num2}, {num3} and {num4} is: {avg}");
            
            
            //10. Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z.
            int num1, num2, num3;
            
            Console.WriteLine("input number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result1 = (num1+num2)*num3;
            int result2 = (num1 * num2) + (num2 * num3);
            Console.WriteLine($"Result of specified numbers {num1}, {num2}, {num3}, (x+y).z is {result1} and x.y + y.z is {result2}");
    


        }
    }
}