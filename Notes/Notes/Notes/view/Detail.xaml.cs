using Notes.Model;
using Notes.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        private CartViewModel _cartViewModel=new CartViewModel();
        CartModel model;
        public Detail(int id)
        {
            InitializeComponent();
            model=_cartViewModel.itemPreview.Where(i=>i.Id==id).FirstOrDefault() ;
            this.BindingContext = model;
        }


      
    }
}