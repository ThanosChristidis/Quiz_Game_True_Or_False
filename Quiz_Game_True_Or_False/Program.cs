using System;

namespace Quiz_Game_True_Or_False
{
    class Program
    {
        
        static void RunQuiz(string[] questions, bool[] answers)
        {

            int askingIndex = 0;
            string input = "";
            bool isBool;
            bool inputBool;
            int scoringIndex = 0;
            int score = 0;
            bool response;

            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");

            bool[] responses = new bool[questions.Length];

            if (answers.Length != questions.Length)
            {
                Console.WriteLine("Warning! Questions and Responses doesn't have equal amount. Please fix the problem, before you procceed!");
            }
            else
            {
                foreach (string question in questions)
                {
                    Console.WriteLine(question);
                    Console.WriteLine("True or False?");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                    while (!isBool)
                    {
                        Console.WriteLine("Please respond with 'true' or 'false'.");
                        input = Console.ReadLine();
                        isBool = Boolean.TryParse(input, out inputBool);
                    }
                    responses[askingIndex] = inputBool;
                    askingIndex++;
                }

                foreach (bool answer in answers)
                {
                    response = responses[scoringIndex];
                    Console.WriteLine($"Input: {response} | Answer:{answer}");
                    if (response == answer)
                    {
                        score += 1;
                    }
                    scoringIndex++;
                }
                Console.WriteLine($"You score {score} out of {questions.Length} correct");
            }
        }
        static void Main(string[] args)
        {
            string[] questions = { "Is tomato a vegetable?", "Is banana a vegetable?" };
            bool[] answers = { true, false};

            RunQuiz(questions, answers);
        }
    }
}
