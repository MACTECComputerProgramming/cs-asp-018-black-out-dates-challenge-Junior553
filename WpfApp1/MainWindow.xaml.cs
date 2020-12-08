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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Instantiate two Date Time variables
        public DateTime FirstDate, SecondDate; 

        // Get First Date
        public void myCalenderOne_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            FirstDate = myCalenderOne.SelectedDate.Value;
            myFirstDate.Content = FirstDate;
        }

        // Get Second Date
        private void myCalenderTwo_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            SecondDate = myCalenderTwo.SelectedDate.Value;
            mySecondDate.Content = SecondDate;
        }

        // Get Black Out Dates
        private void answerButton_Click(object sender, RoutedEventArgs e)
        {
            SetBlackOutDates(FirstDate, SecondDate);
            DateTime startTime = FirstDate;
            DateTime endTime = SecondDate;

            TimeSpan duration = endTime - startTime;

            answerLabel.Content = duration;
            
        }

        // Call Black Out Methods
        private void SetBlackOutDates(DateTime FirstDate, DateTime SecondDate)
        {
            myCalenderBlackout.BlackoutDates.Add(new CalendarDateRange(FirstDate, SecondDate));
        }
    }
}
