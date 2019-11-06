using MorseCode.Pages;
using System;
using System.Collections.Generic;
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

namespace MorseCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, string> MorseAlphabet = new Dictionary<string, string>(){
             {"A",".−" },
             {"Б","−..." },
             {"В",".−−" },
             {"Г","−−." },
             {"Д","−.." },
             {"Е","." },
             {"Є","..−.." },
             {"Ж","...−" },
             {"З","−−.." },
             {"И","−.−−" },
             {"І",".." },
             {"Ї",".−−−." },
             {"Й",".−−−" },
             {"К","−.−" },
             {"Л",".−.." },
             {"М","−−" },
             {"Н","−." },
             {"О","−−−" },
             {"П",".−−." },
             {"Р",".−." },
             {"С","..." },
             {"Т","−" },
             {"У","..−" },
             {"Ф","..−." },
             {"Х","...." },
             {"Ц","−.−." },
             {"Ч","−−−." },
             {"Ш","−−−−" },
             {"Щ","−−.−" },
             {"Ь","−..−" },
             {"Ю","..−−" },
             {"Я",".−.−" },
             {"1","·−−−−" },
             {"2","··−−−" },
             {"3","···−−" },
             {"4","····−" },
             {"5","·····" },
             {"6","−····" },
             {"7","−−···" },
             {"8","−−−··" },
             {"9","−−−−·" },
             {"0","−−−−−" },
            };
        public MainWindow()
        {
            InitializeComponent();

            frame.Navigate(new Alphabet(MorseAlphabet));
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            switch((sender as RadioButton).Content)
            {
                case "Alphabet":
                frame.Navigate(new Alphabet(MorseAlphabet));
                    break;
                case "Test":
                    frame.Navigate(new Test());
                    break;
                case "Translater":
                    frame.Navigate(new Translater(MorseAlphabet));
                    break;
            }
        }
    }
}
