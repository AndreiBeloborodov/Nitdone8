using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nitdone8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            StackLayout st = new StackLayout();
            Button esm_btn = new Button { Text = "Esmaspäev" };
            st.Children.Add(esm_btn);
            esm_btn.Clicked += new EventHandler(Btns_Click);
            Button tsm_btn = new Button { Text = "Teisipäev" };
            st.Children.Add(tsm_btn);


            Content = st;
        }

        private async void Btns_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)//проверяем текст на кнопке
            {
                case "Esmaspäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new Esmaspaev());//открываем Esmaspäev
                    break;
                case "Teisipäev":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new Teisipaev());//открываем Teisipäev
                    break;

            }
            throw new NotImplementedException();
        }
    }
}
