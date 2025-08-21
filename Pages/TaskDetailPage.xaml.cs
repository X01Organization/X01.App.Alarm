namespace X01.App.Alarm.Pages
{
    public partial class TaskDetailPage : ContentPage
    {
        public TaskDetailPage(AlarmPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
        }
    }
}