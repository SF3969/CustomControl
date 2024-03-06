using CommunityToolkit.Mvvm.ComponentModel;
using Mopups.Services;
using System.Windows.Input;

namespace MauiApp1
{
    public partial class ViewModel : ObservableObject
    {
        public ICommand OpenCommand { get; }

        public ViewModel()
        {
            OpenCommand = new Command(async () => await EditAsync(), () => true); ;
        }

        private async Task EditAsync()
        {
            try
            {
                await MopupService.Instance.PushAsync(new MyPopupPage());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
