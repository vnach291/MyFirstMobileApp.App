using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyFirstMobileApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        string button = string.Empty;
        string innerbutton1 = string.Empty;
        string innerbutton2 = string.Empty;
        string innerbutton3 = string.Empty;
        string innerbutton4 = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        public string StackLayoutTitle
        {
            get { return button; }
            set { SetProperty(ref button, value); }
        }


        protected bool SetProperty<T>(ref T backingStore, T value,
                                      [CallerMemberName] string propertyName = "",
                                      Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
