using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1
            //Console.Write("Enter a number: ");
            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("The number is: " + number);
            //}
            //else
            //{
            //    Console.WriteLine("Error: You must enter a valid integer number.");
            //}
            #endregion
            #region Q2
            // if we use parse it will throw FormatException because int.Parse expects the entire string to be numeric.
            // With TryParse, no exception is thrown. It will just return false.
            //string x = "k12";
            //if (int.TryParse(x, out int y))
            //{
            //    Console.WriteLine("The number is: " + y);
            //}
            //else
            //{
            //    Console.WriteLine("Error: You must enter a valid integer number.");
            //}
            #endregion
            #region Q3
            //The program performs:
            //5.5 + 2.2 = 7.7(approximately)
            //float number1 = 5.5f;
            //float number2 = 2.2f;
            //float result = number1 + number2;
            //Console.WriteLine("Result: " + result);
            #endregion
            #region Q4
            //string text = "Hello World";
            //string result = text.Substring(6, 5);
            //Console.WriteLine(result);
            #endregion
            #region Q5
            //string text = "Hello World";
            //string result = text.Substring(3, 5);
            //Console.WriteLine(result);
            //#endregion
            //#region Q5
            //int x = 4;
            //int y = 5;
            //x = y;
            //y = 4;
            //In C#, with value types, the actual value is stored directly in the memory location (usually on the stack), and when you assign it to another variable, a copy of the value is made — not a reference

            #endregion
            #region Q6
            //make class name Person and (have string Name)
            //Person p1 = new Person();
            //p1.Name = "Ali";

            //Person p2 = p1;
            //p2.Name = "Mohamed";
            //When you assign one reference type variable to another in C#, both variables point to the same object in memory, so changes through one affect the other
            #endregion
            #region Q7
            //string x=Console.ReadLine();
            //string y = Console.ReadLine();
            //Console.WriteLine(x+" "+y);
            #endregion
            #region Q8
            //double principal = 1000;
            //double rate = 5;
            //double time = 2;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine("Simple Interest: " + interest);
            #endregion
            #region Q9
            //double weight = 70;
            //double height = 1.75;
            //double bmi = weight / (height * height);
            //Console.WriteLine("BMI: " + bmi);
            #endregion
            #region Q10
            //int temperature = 25;

            //string result = (temperature < 10) ? "Just Cold"
            //                : (temperature > 30) ? "Just Hot"
            //                : "Just Good";
            //Console.WriteLine(result);
            #endregion
            #region Q11
            //Console.Write("Enter day: ");
            //int day = int.Parse(Console.ReadLine());
            //Console.Write("Enter month: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.Write("Enter year: ");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} – {month} – {year}");
            #endregion
            #region Q12
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int x))
            //{
            //    if (x % 3 == 0 && x % 4 == 0)
            //        Console.WriteLine("YES");
            //    else
            //        Console.WriteLine("NO");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid integer.");
            //}
            #endregion
            #region Q13
            //string num = Console.ReadLine();
            //if (int.TryParse(num, out int x))
            //{
            //    if (x>0)
            //        Console.WriteLine("positive");
            //    else
            //        Console.WriteLine("negative");

            //}
            //else
            //{
            //    Console.WriteLine("you should enter a vaild int number");
            //}
            #endregion
            #region Q14
            //int x=int.Parse(Console.ReadLine());
            //int y=int.Parse(Console.ReadLine());
            //int z=int.Parse(Console.ReadLine());
            //int temp = 0;
            //if (x > y) { temp = x; x = y; y = temp; }
            //if (x > z) { temp = x; x = z; z = temp; }
            //if (y > z) { temp = y; y = z; z = temp; }
            //Console.WriteLine($"max element = {z}");
            //Console.WriteLine($"min element = {x}");
            #endregion
            #region Q15
            //Console.Write("Enter a number: ");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine("Even");
            //    else
            //        Console.WriteLine("Odd");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            #endregion
            #region Q16
            //Console.Write("Enter a character: ");
            //char c = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine();

            //if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //    Console.WriteLine("Vowel");
            //else
            //    Console.WriteLine("Consonant");
            #endregion
            #region Q17
            Console.Write("Enter month number (1-12): ");
            if (int.TryParse(Console.ReadLine(), out int month))
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        Console.WriteLine("Days in Month: 31");
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        Console.WriteLine("Days in Month: 30");
                        break;
                    case 2:
                        Console.WriteLine("Days in Month: 28 or 29");
                        break;
                    default:
                        Console.WriteLine("Invalid month number.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
            #endregion


        }
    }
}
