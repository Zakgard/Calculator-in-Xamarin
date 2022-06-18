using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        private static double _number1;
        private static double _number2;
        private string[] _errorTextsList = new string[]
        {
            "Вы не ввели первое число!",
            "Вы не ввели второе число!",
            "При делении делитель не может быть равен 0!",
            "Неизвестная ошибка!"
        };
    
        
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            sumButton.Clicked += Button1_Clicked;
            diffirenceButton.Clicked += DiffirenceButton_Clicked;
            multiplyButton.Clicked += MultiplyButton_Clicked;
            divisionButton.Clicked += DivisionButton_Clicked;
        }

        private void DivisionButton_Clicked(object sender, EventArgs e)
        {
            if (!ConditionsCheck())
            {
            _number1 = Convert.ToDouble(num1.Text.ToString());
            _number2 = Convert.ToDouble(num2.Text.ToString());
            totalLAbel.Text = $"{Convert.ToDouble(_number1 / _number2)}";
            }
            else
            {
                (Application.Current).MainPage = new NavigationPage(new MainPage());
            }
                     
        }

        private void MultiplyButton_Clicked(object sender, EventArgs e)
        {
            if (!ConditionsCheck())
            {
            _number1 = Convert.ToDouble(num1.Text.ToString());
            _number2 = Convert.ToDouble(num2.Text.ToString());
            totalLAbel.Text = $"{_number1 * _number2}";
            }
            else
            {
                (Application.Current).MainPage = new NavigationPage(new MainPage());
            }
            
           

        }

        private void DiffirenceButton_Clicked(object sender, EventArgs e)
        {
            if (!ConditionsCheck())
            {
            _number1 = Convert.ToDouble(num1.Text.ToString());
            _number2 = Convert.ToDouble(num2.Text.ToString());
            totalLAbel.Text = $"{_number1 - _number2}";
            }
            else
            {
                (Application.Current).MainPage = new NavigationPage(new MainPage());
            }
                       
                        
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            if (!ConditionsCheck())
            {
            _number1 = Convert.ToInt32(num1.Text.ToString());
            _number2 = Convert.ToInt32(num2.Text.ToString());
            totalLAbel.Text = $"{_number1 + _number2}";
            }
            else
            {
                (Application.Current).MainPage = new NavigationPage(new MainPage());
            }
                
                       
        }

        private bool ConditionsCheck()
        {
            bool isMistake=false;
            int i=3;
            
            if (num1.Text == null)
            {
                i = 0;
                DisplayAlert("Уведомление об ошибке", _errorTextsList[i], "Закрыть");
                isMistake=true;
                OnAppearing();
            }
               
            if (num2.Text == null)
            {
                i = 1;
                DisplayAlert("Уведомление об ошибке", _errorTextsList[i], "Закрыть");
                isMistake = true;
                OnAppearing();
            }
                
            if (num2.Text == "0")
            {
                 i = 2;
                DisplayAlert("Уведомление об ошибке", _errorTextsList[i], "Закрыть");
                isMistake=true;
                OnAppearing();
            }

            return isMistake;
            
        }

        
    }
}
