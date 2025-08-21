namespace X01.App.Alarm.Pages
{
    public partial class AlarmPage : ContentPage
    {
        public AlarmPage(AlarmPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}