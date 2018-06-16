using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Program
    {
        static void Main()
        {
            //---------- EXERCISE 1 ----------
            //Console.Write("Please enter number to multiply by 50: ");
            //int userInput1 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(userInput1 * 50);
            //Console.ReadLine();

            //Console.Write("Please enter number to add to 25: ");
            //int userInput2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(userInput2 + 25);
            //Console.ReadLine();

            //Console.Write("Please enter number to divide by 12.5: ");
            //int userInput3 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(userInput3 / 12.5);
            //Console.ReadLine();

            //Console.Write("Please enter number to see if it is greater than 50: ");
            //int userInput4 = Int32.Parse(Console.ReadLine());
            //bool fiftyTrueOrFalse = userInput4 > 50;
            //Console.WriteLine(fiftyTrueOrFalse);
            //Console.ReadLine();

            //Console.Write("Please enter number to see what the remainder is when divided by 7: ");
            //int userInput5 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine(userInput5 % 7);
            //Console.ReadLine();

            //bool greaterThanAnd = 3 > 2 && 5 > 4;
            //Console.WriteLine(greaterThanAnd);
            //Console.ReadLine();

            //bool greaterThanOr = 3 > 2 || 5 > 4;
            //Console.WriteLine(greaterThanOr);
            //Console.ReadLine();

            //bool plusNotEqual = 2 + 2 != 4;
            //Console.WriteLine(plusNotEqual);
            //Console.ReadLine();


            //---------- EXERCISE 2 ----------
            //Console.WriteLine("Is it true that 5 is greater than 2?");
            //bool ifElseStatement = 5 > 2;
            //if (ifElseStatement)
            //{
            //    Console.WriteLine("Yes, it is true.");
            //}
            //else
            //{
            //    Console.WriteLine("No, it is not true.");
            //}
            //Console.ReadLine();

            //Console.WriteLine("Is it true that 5 is greater than 2?");
            //bool ternaryOp = 5 > 2;
            //string compResult = (ternaryOp) ? "Yes, it is true." : "No, it is not true.";
            //Console.WriteLine(compResult);
            //Console.ReadLine();


            //---------- EXERCISE 3 ----------
            //Console.WriteLine("Enter a number that is greater than or equal to 5.");
            //int number = Convert.ToInt32(Console.ReadLine());
            //bool numTF = false;
            //while (!numTF)
            //{
            //    switch (number)
            //    {
            //        case 1:
            //            Console.WriteLine("1 is not greater than or equal to 5. Try again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 2:
            //            Console.WriteLine("2 is not greater than or equal to 5. Try again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 3:
            //            Console.WriteLine("3 is not greater than or equal to 5. Try again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 4:
            //            Console.WriteLine("4 is not greater than or equal to 5. Try again.");
            //            number = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        default:
            //            Console.WriteLine(number + " is greater than or equal to 5.");
            //            numTF = true;
            //            break;
            //    }
            //}
            //Console.ReadLine();


            //Console.Write("Guess my age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //bool trueOrFalseAge = false;
            //do
            //{
            //    if (age == 25)
            //    {
            //        Console.WriteLine("You're correct!");
            //        trueOrFalseAge = true;
            //    }
            //    else if (age < 25)
            //    {
            //        Console.WriteLine("Ooo too low. Guess again.");
            //        age = Convert.ToInt32(Console.ReadLine());
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ooo too high. Guess again.");
            //        age = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //while (!trueOrFalseAge);
            //Console.ReadLine();


            //---------- EXERCISE 4 ----------
            //string name = "Kevyn";
            //string age = "25";
            //string city = "Sacramento";
            //Console.WriteLine("Hello, my name is " + name + ". I am " + age + " years old. I live in " + city + ".");
            //Console.ReadLine();

            //string hungry = "hungry";
            //hungry = hungry.ToUpper();
            //Console.WriteLine("I am very " + hungry + "!");
            //Console.ReadLine();

            //StringBuilder sb = new StringBuilder();
            //sb.Append("Hello there. ");
            //sb.Append("My name is Kevyn. ");
            //sb.Append("I am 25 years old. ");
            //sb.Append("I live in Sacramento.");
            //Console.WriteLine(sb);
            //Console.ReadLine();


            //---------- EXERCISE 5 ----------
            //string[] stringArray = { "Kevyn", "Alex", "Mark", "Aaron" };
            //Console.Write("Please enter index number: ");
            //int arrayIndex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(stringArray[arrayIndex]);
            //Console.ReadLine();

            //int[] intArray = { 10, 25, 12, 16 };
            //Console.Write("Please enter index number: ");
            //int arrayIndex = Convert.ToInt32(Console.ReadLine());
            //bool falseArray = false;
            //while (!falseArray)
            //{
            //    if (arrayIndex <= 3)
            //    {
            //        Console.WriteLine(intArray[arrayIndex]);
            //        falseArray = true;
            //    }
            //    else
            //    {
            //        Console.Write("That index number does not exist. Please enter a valid index number: ");
            //        arrayIndex = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //Console.ReadLine();

            //List<string> stringList = new List<string>();
            //stringList.Add("Kevyn");
            //stringList.Add("Alex");
            //stringList.Add("Mark");
            //stringList.Add("Aaron");
            //Console.Write("Please enter index number: ");
            //int listIndex = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(stringList[listIndex]);
            //Console.ReadLine();


            //---------- EXERCISE 5 ----------
            //string[] userText = new string[3];
            //for (int i = 0; i < userText.Length; i++)
            //{
            //    Console.Write("Please enter a name: ");
            //    string name = Console.ReadLine();
            //    userText[i] = name;
            //}
            //for (int j = 0; j < userText.Length; j++)
            //{
            //    Console.WriteLine(userText[j]);
            //}
            //Console.ReadLine();

            //List<int> infiniteLoops = new List<int>() { 1, 2, 3, 4 };
            //foreach (int infiniteLoop in infiniteLoops)
            //{
            //    while (infiniteLoop < 3)
            //    {
            //        Console.WriteLine(infiniteLoop);
            //    }
            //}
            //Console.ReadLine();

            //List<int> infiniteLoops = new List<int>() { 1, 2, 3, 4 };
            //foreach (int infiniteLoop in infiniteLoops)
            //{
            //    if (infiniteLoop < 3)
            //    {
            //        Console.WriteLine(infiniteLoop);
            //    }
            //}
            //Console.ReadLine();

            //List<int> infiniteLoops = new List<int>() { 1, 2, 3, 4 };
            //foreach (int infiniteLoop in infiniteLoops)
            //{
            //    if (infiniteLoop <= 3)
            //    {
            //        Console.WriteLine(infiniteLoop);
            //    }
            //}
            //Console.ReadLine();


            //List<string> uniqueNames = new List<string>() { "Kevyn", "Alex", "Aaron", "Mark" };
            //Console.Write("Please enter name to find index number: ");
            //string name = Console.ReadLine();
            //int i = 0;
            //foreach (string uniqueName in uniqueNames)
            //{
            //    if (name == uniqueName)
            //    {
            //        Console.Write("The index number of " + name + " is: " + i);
            //    }
            //    i++;
            //}
            //Console.ReadLine();

            //List<string> uniqueNames = new List<string>() { "Kevyn", "Alex", "Aaron", "Mark" };
            //Console.Write("Please enter name to find index number: ");
            //string name = Console.ReadLine();
            //int i = 0;
            //bool restart = false;
            //while (!restart)
            //{
            //    foreach (string uniqueName in uniqueNames)
            //    {
            //        if (name == uniqueName)
            //        {
            //            Console.Write("The index number of " + name + " is: " + i);
            //            restart = true;
            //        }
            //        i++;
            //    }
            //    if (!restart)
            //    {
            //        Console.Write(name + " is not in the list. Please enter new name: ");
            //        name = Console.ReadLine();
            //        i = 0;
            //    }
            //}
            //Console.ReadLine();

            //List<string> uniqueNames = new List<string>() { "Kevyn", "Alex", "Kevyn", "Mark" };
            //Console.Write("Please enter name to see if there are duplicates: ");
            //string name = Console.ReadLine();
            //int indexCount = 0;
            //int nameCount = 0;
            //List<int> lists = new List<int>();
            //bool restart = false;
            //while (!restart)
            //{
            //    foreach (string uniqueName in uniqueNames)
            //    {
            //        if (name == uniqueName)
            //        {
            //            lists.Add(indexCount);
            //            nameCount++;
            //        }
            //        indexCount++;
            //    }
            //    if (nameCount > 1)
            //    {
            //        Console.WriteLine(name + " has duplicates on index numbers: ");
            //        foreach (int list in lists)
            //        {
            //            Console.WriteLine(list);
            //        }
            //        restart = true;
            //    }
            //    else if (nameCount == 1)
            //    {
            //        Console.Write(name + " has no duplicates.");
            //        restart = true;
            //    }
            //    else if (!restart)
            //    {
            //        Console.Write(name + " is not in the list. Please enter another name: ");
            //        name = Console.ReadLine();
            //        indexCount = 0;
            //        nameCount = 0;
            //    }
            //}
            //Console.ReadLine();


            //List<string> uniqueNames = new List<string>() { "Kevyn", "Alex", "Kevyn", "Mark" };
            //string[,] duplicatesArray = new string[uniqueNames.Count, 2];
            //int indexCount = 0;
            //int duplicateCount = 0;
            //int arrayIndex = 0;
            //while (indexCount < uniqueNames.Count)
            //{
            //    foreach (string uniqueName in uniqueNames)
            //    {
            //        if (uniqueNames[indexCount] == uniqueName)
            //        {
            //            duplicateCount++;
            //        }
            //    }
            //    duplicatesArray[arrayIndex, 0] = uniqueNames[indexCount];
            //    duplicatesArray[arrayIndex, 1] = Convert.ToString(duplicateCount);
            //    duplicateCount = 0;
            //    indexCount++;
            //    arrayIndex++;
            //}
            //int rowLength = duplicatesArray.GetLength(0);
            //int colLength = duplicatesArray.GetLength(1);            
            //for (int i = 0; i < rowLength; i++)
            //{
            //    for (int j = 0; j < colLength; j++)
            //    {
            //        Console.Write(string.Format("{0} ", duplicatesArray[i, j]));
            //    }
            //    Console.Write(Environment.NewLine + Environment.NewLine);
            //}
            //Console.ReadLine();


            //---------- EXERCISE 6 ----------
            //try
            //{
            //    List<double> numbers = new List<double>() { 5.0, 8.0, 10.0, 6.0, 3.0, 7.0 };
            //    Console.Write("Please enter a number to divide each number in list: ");
            //    double divideNumber = Convert.ToDouble(Console.ReadLine());
            //    foreach (double number in numbers)
            //    {
            //        double equalsNumber = number / divideNumber;
            //        Console.WriteLine(number + " / " + divideNumber + " = " + equalsNumber);
            //    }
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.Write("Error: ");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.Write("Error: ");
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Message: Program has emerged from the try/catch block and continued on with program execution.");
            //    Console.ReadLine();
            //}





        }
    }
}
