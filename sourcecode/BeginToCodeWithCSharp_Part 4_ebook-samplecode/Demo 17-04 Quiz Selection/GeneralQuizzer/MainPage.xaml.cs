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

namespace GeneralQuizzer
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

            quizTopicComboBox.Items.Add(new AdditionQuizObject());
            quizTopicComboBox.Items.Add(new SubtractionQuizObject());
            quizTopicComboBox.Items.Add(new MultiplicationQuizObject());
            quizTopicComboBox.Items.Add(new DivisionQuizObject());
            quizTopicComboBox.SelectedIndex = 0;
        }

        void setupNextQuestion()
        {
            activeQuiz.NextQuestion();
            questionTextBlock.Text = activeQuiz.GetQuestion();
            answerTextBox.Text = "";
            resultTextBlock.Text = "";
        }


        private void getNextQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            setupNextQuestion();
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

        IQuizObject activeQuiz;

        private void quizTopicComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            activeQuiz = (IQuizObject)quizTopicComboBox.SelectedItem;
            setupNextQuestion();
        }
    }
}
