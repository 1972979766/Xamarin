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
       
    }
}
