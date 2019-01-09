using Infrastructure;

namespace ModulA.ViewModels
{
    public class ViewAViewModel : ViewModelBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel()
        {
            Title = "ViewA";
            Message = "View A from your Prism Module";
        }
    }
}
