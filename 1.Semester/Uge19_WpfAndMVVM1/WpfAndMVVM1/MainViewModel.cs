using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfAndMVVM1
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _myLabelText = "Text not yet set";

        public string MyLabelText
        {
            get { return _myLabelText; }
            set
            {
                _myLabelText = value;
                OnPropertyChanged("MyLabelText");
            }
        }

        private string _myTextBoxText = "Text not yet set";



        public string MyTextBoxText
        {
            get { return _myTextBoxText; }
            set
            {
                _myTextBoxText = value;
                OnPropertyChanged("MyTextBoxText");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
