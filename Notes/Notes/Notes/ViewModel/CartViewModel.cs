﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Notes.Model;
using Xamarin.Forms;

namespace Notes.ViewModel
{
    public class CartViewModel: INotifyPropertyChanged
    {
        public ObservableCollection<CartModel> itemPreview { get; private set; }
        public ObservableCollection<CartModel> newPreview { get; private set; }
        public ICommand DeleteCommand => new Command<CartModel>(RemoveCart);
        public CartViewModel() {
            itemPreview = new ObservableCollection<CartModel>();
            newPreview = new ObservableCollection<CartModel>();
            CreateItemCollection();
            CreateItemCollectionNew();
        }
        void RemoveCart(CartModel cart)
        {
            if (itemPreview.Contains(cart))
            {
                itemPreview.Remove(cart);
            }
            if (newPreview.Contains(cart))
            {
                newPreview.Remove(cart);
            }
        }
        void CreateItemCollection() {
            
            for (int i = 0; i < 6; i++)
            {
               
                itemPreview.Add(new CartModel
                {
                    Id = i,
                    No = i+1,
                    Descrpation = "陽光 活潑 帥氣 大方",
                    Hobby = "陽光",
                    Laction = "上海" + i,
                    Image = "Image1.png",
                    Price = "5k"
                });
            }
            
            
        }
        void CreateItemCollectionNew()
        {

            for (int i = 0; i < 40; i++)
            {

                newPreview.Add(new CartModel
                {
                    Id = i,
                    No = i+1,
                    Descrpation = "陽光 活潑 帥氣 大方",
                    Hobby = "陽光",
                    Laction = "上海" + i,
                    Image = "Image1.png",
                    Price = "5k"
                });
            }


        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
