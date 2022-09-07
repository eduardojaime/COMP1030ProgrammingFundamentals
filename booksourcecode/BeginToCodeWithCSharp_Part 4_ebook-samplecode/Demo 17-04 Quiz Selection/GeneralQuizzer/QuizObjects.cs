using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralQuizzer
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

        public override string ToString()
        {
            return "Always wrong quiz";
        }

    }

    abstract class CalculationQuizObject : IQuizObject
    {
        protected Random rand = new Random();

        protected string currentQuestion;

        protected int currentAnswer;

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

        public abstract void NextQuestion();
    }

    class AdditionQuizObject : CalculationQuizObject
    {

        public override void NextQuestion()
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

        public override string ToString()
        {
            return "Addition quiz";
        }
    }

    class SubtractionQuizObject : CalculationQuizObject
    {
        public override void NextQuestion()
        {
            int firstNum = rand.Next(0, 10);
            int secondNum = rand.Next(0, 10);
            currentQuestion = "What is " + firstNum + " - " + secondNum;
            currentAnswer = firstNum - secondNum;
        }

        public SubtractionQuizObject()
        {
            NextQuestion();
        }

        public override string ToString()
        {
            return "Subtraction quiz";
        }
    }

    class MultiplicationQuizObject : CalculationQuizObject
    {
        public override void NextQuestion()
        {
            int firstNum = rand.Next(0, 10);
            int secondNum = rand.Next(0, 10);
            currentQuestion = "What is " + firstNum + " * " + secondNum;
            currentAnswer = firstNum * secondNum;
        }

        public MultiplicationQuizObject()
        {
            NextQuestion();
        }

        public override string ToString()
        {
            return "Multiplication quiz";
        }
    }

    class DivisionQuizObject : CalculationQuizObject
    {
        public override void NextQuestion()
        {
            int firstNum = rand.Next(1, 10);
            int secondNum = rand.Next(1, 10);
            int product = firstNum * secondNum;
            currentQuestion = "What is " + product + " / " + firstNum;
            currentAnswer = secondNum;
        }

        public DivisionQuizObject()
        {
            NextQuestion();
        }

        public override string ToString()
        {
            return "Division quiz";
        }
    }
}
