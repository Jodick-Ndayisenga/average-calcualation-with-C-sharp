using System;
internal class Program
{
    static void Main(string[] args)
    {

        Console.Write(" What is the name of your first student: ");
        string firstStudent = Console.ReadLine();
        Console.Write(" How many did this student score in the first Quiz: ");
        int firstQuizScore = int.Parse(Console.ReadLine());

        Console.Write(" How many did this student score in the second Quiz: ");
        int secondQuizScore = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");


        Console.Write(" What is the name of your second student: ");
        string secondStudent = Console.ReadLine();
        Console.Write(" How many did this student score in the first Quiz: ");
        int firstQuizScore2 = int.Parse(Console.ReadLine());

        Console.Write(" How many did this student score in the second Quiz: ");
        int secondQuizScore2 = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");


        Console.Write(" What is the name of your third student: ");
        string thirdStudent = Console.ReadLine();
        Console.Write(" How many did this student score in the first Quiz: ");
        int firstQuizScore3 = int.Parse(Console.ReadLine());

        Console.Write(" How many did this student score in the second Quiz: ");
        int secondQuizScore3 = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");


        Console.Write(" What is the name of your fourth student: ");
        string fourthStudent = Console.ReadLine();
        Console.Write(" How many did this student score in the first Quiz: ");
        int firstQuizScore4 = int.Parse(Console.ReadLine());

        Console.Write(" How many did this student score in the second Quiz: ");
        int secondQuizScore4 = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" Names\t\tQuiz I\t\tQuiz II\t\tTotal");
        Console.ResetColor();
        Console.WriteLine(" ------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {firstStudent}\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" {firstQuizScore}\t\t{secondQuizScore}\t\t");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{firstQuizScore + secondQuizScore}");
        Console.ForegroundColor = ConsoleColor.White;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {secondStudent}\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" {firstQuizScore2}\t\t{secondQuizScore2}\t\t");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{firstQuizScore2 + secondQuizScore2}");
        Console.ForegroundColor = ConsoleColor.White;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {thirdStudent}\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" {firstQuizScore3}\t\t{secondQuizScore3}\t\t");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{firstQuizScore3 + secondQuizScore3}");
        Console.ForegroundColor = ConsoleColor.White;

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($" {fourthStudent}\t\t");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($" {firstQuizScore4}\t\t{secondQuizScore4}\t\t");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{firstQuizScore4 + secondQuizScore4}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}