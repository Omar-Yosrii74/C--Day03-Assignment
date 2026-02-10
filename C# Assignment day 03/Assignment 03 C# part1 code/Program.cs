//using System;
//using System.Globalization;
//using System.Text;

//namespace AssignmentDay03CSharp
//{
//    class program
//    {

//        static void Main(string[] args)
//        {
//            #region Part 1

//            #region problem1
//            //  problem 1
//            //  parse
//            try
//            {
//                Console.WriteLine("enter a number: ");
//                String input = Console.ReadLine();

//                int num = int.Parse(input);
//                Console.WriteLine(num);
//            }
//            catch (Exception)
//            {
//                Console.WriteLine("enter a valid number");
//            }

//            // ToInt32
//            try
//            {
//                Console.WriteLine("enter a number: ");
//                String input2 = Console.ReadLine();
//                int num2 = Convert.ToInt32(input2);
//            }
//            catch
//            {
//                Console.WriteLine("enter a valid number: ");
//            }

//            /* COMMENT question 1 answewr :
             
//             Using parse with null inputs makes programm crash
//             Using toint32 with null inputs returns zero
            
//             */
//            #endregion


//            #region problem2
//            //problem 2

//            Console.WriteLine("Enter a number: ");
//            String input3 = Console.ReadLine();

//            if (int.TryParse(input3, out int result))
//            { Console.WriteLine(result); }
//            else { Console.WriteLine("invalid number "); }

//            /* COMMENT
//             question 2 answer:

//             try parse is recommended over parse because it handles
//             null inputs, characters without crashing the programm
//             and provides better performance 
            
//             */
//            #endregion


//            #region problem3
//            //problem 3

//            object obj1;
//            obj1 = 10;
//            Console.WriteLine(obj1.GetHashCode());

//            obj1 = "hello";
//            Console.WriteLine(obj1.GetHashCode());

//            obj1 = 12.5;
//            Console.WriteLine(obj1.GetHashCode());

//            /* COMMENT
//             question 3 answer :
//             itspurpose is to generate a unique number referrs
//             to the object like an ID 
//             */
//            #endregion


//            #region problem4
//            //problem 4

//            StringBuilder sb1 = new StringBuilder("hi");
//            StringBuilder sb2 = sb1;

//            Console.WriteLine(sb1.GetHashCode()); //the same
//            Console.WriteLine(sb2.GetHashCode()); //the same 

//            sb1.Append("FRIENDS! ");
//            Console.WriteLine(sb2); // "hi FRIENDS"

//            /* COMMENT
//              question 4 nswer :
//              it is that two variables point to the same location(carry the
//              same address) in memory.and even if two objects have identical 
//              data they will be reference equal only when they have the same adddress
//             */
//            #endregion


//            #region problem 5
//            //problem 5

//            String message = "good morning";
//            Console.WriteLine(message.GetHashCode());
//            message += ",hi willy";
//            Console.WriteLine(message.GetHashCode());

//            /* COMMENT
//             question 5 answer : 
//             String is immutable meaning its valeu can't be 
//             modified or changed and that's because it's originally 
//             a fixed size array of characters that can't be changed.                                                    
//            */

//            #endregion


//            #region problem6
//            //problem 6 

//            StringBuilder sb3 = new StringBuilder("Hi Willy");
//            Console.WriteLine(sb3.GetHashCode());
//            sb3.AppendLine(",Call Me Later ");
//            Console.WriteLine(sb3.GetHashCode());

//            /* COMMENT
//              Question 6 answer :
//              The StringBuilder class overcomes the inefficiency of string
//              immutability as : concatenating a string creates a completely
//              new object in memory each time, While StringBuilder is mutable
//              and modifies the existing object in place . 

//              It prevents extra memory allocation , improve performance
//             */
//            #endregion

//            /* COMMENT
//             QUESTION answer (stringbuilder faster for large-scale)
//             because it doesn't need to create a new object every time 
//             using memory resources and GC .
//             */


//            #region problem7
//            //problem 7

//            Console.WriteLine("Enter first number: ");
//            int a = int.Parse(Console.ReadLine());

//            Console.Write("Enter second number: ");
//            int b = int.Parse(Console.ReadLine());

//            Console.WriteLine("Sum is " + (a + b));
//            Console.WriteLine(string.Format("Sum is {0}", a + b));
//            Console.WriteLine($"Sum is {a + b}");

//            /* COMMENT
//              Question 7 answer :
//              String interpolation with $ is the most used because
//              it is easier to read ,write and the others is more likely
//              to have errors.
//             */

//            #endregion


//            #region problem8
//            //problem 8

//            StringBuilder builder = new StringBuilder("HI");

//            builder.Append(" World");
//            builder.Replace("World", "C#");
//            builder.Insert(0, "Say: ");
//            builder.Remove(0, 4);

//            Console.WriteLine(builder.ToString());

//            /* COMMENT
//             Question 8 answer :
//             String Builder is designed to modify string in-place
//             using internal buffer , avoids creating multible objects
//             in memory. as the opposite of string concatination .
//             */

//            #endregion


//            #endregion 
//        }
//    }
//}