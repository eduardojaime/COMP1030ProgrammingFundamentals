using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationQuizzer
{
    interface IQuizObject
    {
        string GetQuestion();
        bool CheckAnswer(string answer);
        void NextQuestion();
    }

    class FakeWrongQuiz : IQuizObject
    {
        public bool CheckAnswer(string answer)
        {
            return false;
        }

        public string GetQuestion()
        {
            return "The answer to this question is always wrong";
        }

        public void NextQuestion()
        {
        }
    }

    class AdditionQuizObject : IQuizObject
    {
        private Random rand = new Random();

        private string currentQuestion;

        private int currentAnswer;

        public string GetQuestion()
        {
            return currentQuestion;
        }

        public bool CheckAnswer(string answer)
        {
            int answerValue;
            if (int.TryParse(answer, out answerValue))
            {
                if (answerValue == currentAnswer)
                    return true;
            }
            return false;
        }

        public void NextQuestion()
        {
            int firstNum = rand.Next(0, 10);
            int secondNum = rand.Next(0, 10);
            currentQuestion = "What is " + firstNum + " + " + secondNum;
            currentAnswer = firstNum + secondNum;
        }

        public AdditionQuizObject()
        {
            NextQuestion();
        }
    }
}
