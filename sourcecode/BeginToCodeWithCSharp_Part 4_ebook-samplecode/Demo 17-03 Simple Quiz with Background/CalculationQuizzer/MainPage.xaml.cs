using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalculationQuizzer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        IQuizObject activeQuiz;

        public MainPage()
        {
            this.InitializeComponent();

            activeQuiz = new AdditionQuizObject();
            questionTextBlock.Text = activeQuiz.GetQuestion();
        }

        private void getNextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            activeQuiz.NextQuestion();
            questionTextBlock.Text = activeQuiz.GetQuestion();
            answerTextBox.Text = "";
            resultTextBlock.Text = "";
        }

        private void checkAnswerButton_Click(object sender, RoutedEventArgs e)
        {
            if (activeQuiz.CheckAnswer(answerTextBox.Text))
            {
                resultTextBlock.Text = "Correct! Well done.";
                Uri soundsource = new Uri("ms-appx:///Sounds/right.wav");
                soundMediaElement.Source = soundsource;
                soundMediaElement.Play();
            }
            else
            {
                resultTextBlock.Text = "Sorry, that is not correct.";
                Uri soundsource = new Uri("ms-appx:///Sounds/wrong.wav");
                soundMediaElement.Source = soundsource;
                soundMediaElement.Play();
            }
        }
    }
}
