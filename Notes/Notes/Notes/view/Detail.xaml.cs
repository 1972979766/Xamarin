using Notes.Model;
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
    public partial class Detail : MasterDetailPage
    {
        Person Person;
        int id;
        public Detail(int id)
        {
            InitializeComponent();
           // MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            id = id;
            this.Appearing += Detail_Appearing;
            
        }

        private async void Detail_Appearing(object sender, EventArgs e)
        {

            Person= await App.Database.GetItemAsync(id);
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as DetailMasterMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}