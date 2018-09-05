using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Template_MVVM.ViewModels
{
    class MainViewModel : ViewModelBase, IClosableViewModel, INotifyPropertyChanged
    {

        public event EventHandler CloseWindowEvent;
        public event PropertyChangedEventHandler PropertyChanged;
        public MainViewModel()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void CloseApplication()
        {
            Application.Current.MainWindow.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
