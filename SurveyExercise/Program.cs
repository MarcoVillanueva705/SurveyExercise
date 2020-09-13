using System;

namespace SurveyExercise
{
    //create a Data class
    class Data
    {
        //create fields for Data class
        //i.e blueprint for what Data is
        public string Name;
        public int Age;
        public string Month;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();
        }

        static string TryAnswer()
        {
            var question = Console.ReadLine();
            if (question == "")
            {
                Console.WriteLine("Answer cannot be blank!");
            }
            return question;
        }
    }
}
