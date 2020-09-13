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

        public void Display()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your birth month is: {0}", Month);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Data Class
            var data = new Data();

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
