using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationQuizzer
{
    /// <summary>
    /// An object that can be used to generate 
    /// and test quiz questions
    /// </summary>
    interface IQuizObject
    {
        /// <summary>
        /// Gets the text for a question
        /// </summary>
        /// <returns>the question text</returns>
        string GetQuestion();

        /// <summary>
        /// Checks to see if an answer is correct
        /// </summary>
        /// <param name="answer">Answer to be tested</param>
        /// <returns>true if the answer is correct</returns>
        bool CheckAnswer(string answer);

        /// <summary>
        /// Moves onto the next question
        /// </summary>
        void NextQuestion();
    }

    /// <summary>
    /// A quiz object that regards any answer given as wrong
    /// </summary>
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

    /// <summary>
    /// A quiz object that implements an addition quiz
    /// </summary>
    class AdditionQuizObject : IQuizObject
    {
        /// <summary>
        /// Random number generator used by the quiz
        /// </summary>
        private Random rand = new Random();

        /// <summary>
        /// Current question being asked by the object, as a string
        /// </summary>
        private string currentQuestion;

        /// <summary>
        /// Answer value, which is an integer
        /// </summary>
        private int currentAnswer;

        public string GetQuestion()
        {
            //Just return the current question
            return currentQuestion;
        }

        public bool CheckAnswer(string answer)
        {

            int answerValue;

            // Convert the parameter into a number
            if (int.TryParse(answer, out answerValue))
            {
                // If the number conversion succeeds
                // check against the answer
                if (answerValue == currentAnswer)
                    // return true if the answer is correct
                    return true;
            }
            // either the answer was wrong or the user did
            // not enter a number. Return false
            return false;
        }

        public void NextQuestion()
        {
            // Generate two numbers in the range 0 to 9
            int firstNum = rand.Next(0, 10);
            int secondNum = rand.Next(0, 10);

            // Store the question string 
            currentQuestion = "What is " + firstNum + " + " + secondNum;

            // Store the correct answer
            currentAnswer = firstNum + secondNum;
        }

        public AdditionQuizObject()
        {
            // When the object is created set up 
            // the first question
            NextQuestion();
        }
    }
}
