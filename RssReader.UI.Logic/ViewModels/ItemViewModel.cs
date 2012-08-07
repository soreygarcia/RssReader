using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using RssReader.UI.Logic.Common;

namespace RssReader.UI.Logic.ViewModels
{
    public class ItemViewModel : BindableBase
    {
        private string content;
        private DateTime date;
        private string icon;
        private string identifier;
        private string title;

        public ItemViewModel()
        {

        }

        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                NotifyPropertyChanged("Content");
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                NotifyPropertyChanged("Date");
            }
        }

        public string Icon
        {
            get
            {
                return icon;
            }
            set
            {
                icon = value;
                NotifyPropertyChanged("Icon");
            }
        }

        public string Identifier
        {
            get
            {
                return identifier;
            }
            set
            {
                identifier = value;
                NotifyPropertyChanged("Identifier");
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                NotifyPropertyChanged("Title");
            }
        }
    }
}