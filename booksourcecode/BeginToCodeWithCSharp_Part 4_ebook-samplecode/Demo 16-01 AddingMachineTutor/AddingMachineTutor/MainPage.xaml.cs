using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
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

namespace AddingMachineTutor
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private void displayResult()
        {
            float v1 = float.Parse(firstNumberTextBox.Text);
            float v2 = float.Parse(secondNumberTextBox.Text);

            float result = v1 + v2;

            resultTextBlock.Text = result.ToString();
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