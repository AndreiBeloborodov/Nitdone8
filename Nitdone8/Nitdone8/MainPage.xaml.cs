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
            tsm_btn.Clicked += new EventHandler(Btns_Click);
            Button klm_btn = new Button { Text = "Kolmapäev" };
            st.Children.Add(klm_btn);
            klm_btn.Clicked += new EventHandler(Btns_Click);
            Button nlm_btn = new Button { Text = "Neljapäev" };
            st.Children.Add(nlm_btn);
            nlm_btn.Clicked += new EventHandler(Btns_Click);
            Button rdl_btn = new Button { Text = "Reedel" };
            st.Children.Add(rdl_btn);
            rdl_btn.Clicked += new EventHandler(Btns_Click);
            Button lul_btn = new Button { Text = "Laupäev" };
            st.Children.Add(lul_btn);
            lul_btn.Clicked += new EventHandler(Btns_Click);
            Button puh_btn = new Button { Text = "Pühapäev" };
            st.Children.Add(puh_btn);
            puh_btn.Clicked += new EventHandler(Btns_Click);



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
