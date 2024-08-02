using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    internal class Quetions
    {
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        private uint CorrectAnswerIdx { get; set; }

        public Quetions(string questionText, string[] anss, uint correctAnsIdx)
        {
            QuestionText = questionText;
            Answers = anss;
            CorrectAnswerIdx = correctAnsIdx;
        }
        public bool IsCorrectAnswer (uint userChoice)
        {
            return --userChoice == CorrectAnswerIdx;
        }
    }
}
