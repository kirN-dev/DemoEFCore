using DemoEFCore.Core;

namespace DemoEFCore.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        private string _title;

        public string Title
        {
            get => _title;
            set => OnPropertyChanged(ref _title, value);
        }

    }
}