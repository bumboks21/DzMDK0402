using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using WPFAuthorization.Command;
using WPFAuthorization.Model;
using WPFAuthorization.View.Windows;
using WPFAuthorization.Core;

namespace WPFAuthorization.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private User _userLoging;
        public User UserLoging
        {
            get => _userLoging;
            set
            {
                _userLoging = value;
                OnPropertyChanged(nameof(UserLoging));
            }
        }
        public void ExitEx()
        {
            foreach (Window item in Application.Current.Windows)
            {
                if (item is MainWindow) item.Close();
            }
        }
        private void Close(object Object)
        {
            ExitEx();
        }
        public ICommand ExitCommand { get; }
        private void Validation_Method(object Object)
        {
            if (!string.IsNullOrWhiteSpace(UserLoging.Login) && !string.IsNullOrWhiteSpace(UserLoging.Password))
            {

                if (Validation.ValidationMetod(UserLoging))
                {
                    MessageBox.Show("Авторизация прошла успешно!!!", "Успешно!", MessageBoxButton.OK);
                    TimeTableWindow timetableWindow = new TimeTableWindow();
                    timetableWindow.Show();
                    ExitEx();
                }
                else
                {
                    MessageBox.Show("Введённые данные неверны!", "Ошибка", MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены!", "Oшибка", MessageBoxButton.OK);
            }
        }
        public ICommand ValidationCommand { get; }
        public MainWindowViewModel()
        {
            _userLoging = new User();
            ExitCommand = new RelativeCommand(Close);
            ValidationCommand = new RelativeCommand(Validation_Method);
        }


    }
}
