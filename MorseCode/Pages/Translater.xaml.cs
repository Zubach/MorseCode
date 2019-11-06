using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MorseCode.Pages
{
    /// <summary>
    /// Interaction logic for Translater.xaml
    /// </summary>
    public partial class Translater : Page
    {
        Dictionary<string, string> MorseAlphabet = new Dictionary<string, string>();
        bool IsMorse = true;
     
        public Translater()
        {
            InitializeComponent();
        }

        public Translater(Dictionary<string, string> MorseAlphabet)
        {
            InitializeComponent();
            this.MorseAlphabet = MorseAlphabet;
        }
        
        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Content == "MORSE")
            {
                (sender as Button).Content = "UKRAINIAN";
                
            }
            else
            {
                (sender as Button).Content = "MORSE";
            }
            IsMorse = !IsMorse;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsMorse)
            {
                var collection = InputTextBox.Text.Split(' ');
                OutputTextBox.Text = "";
                foreach(var item in collection)
                {
                    
                    OutputTextBox.Text = MorseAlphabet.FirstOrDefault(x => x.Value == item).Key;
                }
                
            }
        }
    }
}
