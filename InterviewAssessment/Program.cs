using question1;
using System;

namespace InterviewAssessment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            QuestionOne questionOne = new QuestionOne();
            questionOne.Challenge(new int[] { 2, 1, 1, 6 });
        }
    }
}
