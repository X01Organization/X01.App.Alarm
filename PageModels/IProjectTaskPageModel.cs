using CommunityToolkit.Mvvm.Input;
using X01.App.Alarm.Models;

namespace X01.App.Alarm.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}