using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.ComponentModel;

namespace RssReader.UI.Logic.Common
{
    public class BindableBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool _isWorking;
        public bool IsWorking
        {
            set
            {
                this._isWorking = value;
                NotifyPropertyChanged("IsWorking");
            }
            get
            {
                return _isWorking;
            }
        }

        private string _statusMessage;
        public string StatusMessage
        {
            set
            {
                this._statusMessage = value;
                NotifyPropertyChanged("StatusMessage");
            }
            get
            {
                return _statusMessage;
            }
        }
    }
}
