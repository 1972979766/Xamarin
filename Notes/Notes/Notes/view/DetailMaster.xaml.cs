using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes.view
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailMaster : ContentPage
    {
        public ListView ListView;

        public DetailMaster()
        {
            InitializeComponent();

            BindingContext = new DetailMasterViewModel();
            ListView = MenuItemsListView;
        }

        class DetailMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<DetailMasterMenuItem> MenuItems { get; set; }

            public DetailMasterViewModel()
            {
                MenuItems = new ObservableCollection<DetailMasterMenuItem>(new[]
                {
                    new DetailMasterMenuItem { Id = 0, Title = "Page 1" },
                    new DetailMasterMenuItem { Id = 1, Title = "Page 2" },
                    new DetailMasterMenuItem { Id = 2, Title = "Page 3" },
                    new DetailMasterMenuItem { Id = 3, Title = "Page 4" },
                    new DetailMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}