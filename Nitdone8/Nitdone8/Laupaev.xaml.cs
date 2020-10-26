using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nitdone8
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Laupaev : ContentPage
    {
        public Laupaev()
        {
            //InitializeComponent();
            //массив-план на день
            string[] tasks = new string[] { "Встал", "Зарядка", "Работа рукой(Правая)", "Ванная-раковина", "Туалет", "Спать" };
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_itemselected;//инициализируем функцию при клике на пункты списка
            Content = new StackLayout { Children = { list } };//отображаем список  на странице 
        }
        string kell;
        private async void List_itemselected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)//если выбран первый элемент списка
                {
                    kell = "7:00";
                }
                else if (e.SelectedItemIndex == 1)//если выбран второй элемент списка
                {
                    kell = "8:00";
                }
            }
        }
    }
}
        