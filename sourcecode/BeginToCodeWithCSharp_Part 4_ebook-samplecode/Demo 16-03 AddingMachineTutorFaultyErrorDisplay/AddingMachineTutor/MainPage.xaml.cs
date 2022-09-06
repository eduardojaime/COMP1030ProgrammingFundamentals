using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AddingMachineTutor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        Brush errorBrush = new SolidColorBrush(Colors.Red);

        private void displayResult()
        {

            float v1;
            float v2;
            bool validValues = true;

            if (float.TryParse(firstNumberTextBox.Text, out v1) == false)
            {
                validValues = false;
                firstNumberTextBox.Background = errorBrush;
            }

            if (float.TryParse(secondNumberTextBox.Text, out v2) == false)
            {
                validValues = false;
                secondNumberTextBox.Background = errorBrush;
            }

            if (validValues)
            {
                float result = v1 + v2;
                resultTextBlock.Text = result.ToString();
            }
            else
            {
                resultTextBlock.Text = "Invalid number";
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            displayResult();
        }
    }
}
