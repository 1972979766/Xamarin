using Notes.DataBase;
using Notes.Model;
using Notes.Model.WeatherMapModel;
using Notes.view;
using Notes.ViewModel;
using Notes.WebServiceTutorial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        private CartViewModel _cartViewModel;
        public  MainPage()
        {
            InitializeComponent();
            this.BindingContext = _cartViewModel = new CartViewModel();
        }
       private async void TapGestureRecognizer_Tapped() {
            int id = 1;
            await Navigation.PushModalAsync(new Detail(id));
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
           var model= sender as CartModel;
            await Navigation.PushModalAsync(new Detail(1));
        }
    }
}
