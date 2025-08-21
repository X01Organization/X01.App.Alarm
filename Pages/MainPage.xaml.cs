using X01.App.Alarm.Models;
using X01.App.Alarm.PageModels;

namespace X01.App.Alarm.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}