using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using RssReader.UI.Logic.Common;

namespace RssReader.UI.Logic.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<ItemViewModel>();
            this.Tweets = new ObservableCollection<MessageViewModel>();
        }

        public ObservableCollection<ItemViewModel> Items { get; private set; }
        public ObservableCollection<MessageViewModel> Tweets { get; private set; }

        private ItemViewModel selectedItem;
        public ItemViewModel SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        public void LoadData()
        {
            //TODO: Cargar datos
            this.IsDataLoaded = true;
        }
    }
}