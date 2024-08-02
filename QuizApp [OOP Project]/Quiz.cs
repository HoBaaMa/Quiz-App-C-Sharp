using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quiz
    {
        private Quetions[] _quetions;
        private uint _score;
        public Quiz(Quetions[] quetions)
        {
            Console.WriteLine("Welcome to the Quiz!");
            Thread.Sleep(1500);
            Console.WriteLine("So Let's Start Now!, Wish You Good Luck :).\n");
            Thread.Sleep(1500);
            this._quetions = quetions;
            _score = 0;
        }
        public void StartQuiz ()
        {
            foreach (var quetion in _quetions)
            {
                DisplayQuestion(quetion);
                CheckUserAnswer(quetion);
            }
            DisplayResult();
        }
        private void DisplayQuestion (Quetions question)
        {
            uint questionNumber = 1;
            Console.ForegroundColor = ConsoleColor.Red; // changes the text color
            Console.Write($"Question #{questionNumber++}: ");
            Console.ResetColor(); // restes the foreground (text) color to the default color
            Console.WriteLine($"{question.QuestionText}");
            
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{i + 1}.");
                Console.ResetColor();
                Console.WriteLine($"{question.Answers[i]}");
            }
        }
        private uint GetUserChoice()
        {
            Console.Write("Enter Your Answer: ");
            string input = Console.ReadLine();
            uint choice;
            while (!uint.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid input");
                Console.ResetColor();
                Console.Write(", please enter a number between 1 and 4 : ");
                input = Console.ReadLine();
            }

            return choice;
        }
        private void CheckUserAnswer(Quetions quetion)
        {
            if (quetion.IsCorrectAnswer(GetUserChoice()))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!\n");
                _score++;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect!\n");
            }
        }
        private void DisplayResult()
        {
            Console.ResetColor();
            Console.WriteLine($"Your Score Is {_score}/{_quetions.Length}");
            double percentage = (_score / (double)_quetions.Length) * 100;
            //Console.WriteLine(percentage.ToString("F2")); // F2 means 2 decimal places (setting precision)
            if (percentage >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
            }
            else if (percentage >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Good Effort!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Keep Parcticing!");
            }
            Console.ResetColor();
        }
    }
}
