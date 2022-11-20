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
using System.Windows.Shapes;
using WPFAuthorization.View.Pages;

namespace WPFAuthorization.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для TimeTableWindow.xaml
    /// </summary>
    public partial class TimeTableWindow : Window
    {
        public TimeTableWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new TimeTablePage());

        }
        private void TeacherButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TeacherPage());
        }

        private void TimeTableButton_Click(object sender, RoutedEventArgs e)
        {
          MainFrame.Navigate(new TimeTablePage());
        }
    }
}
