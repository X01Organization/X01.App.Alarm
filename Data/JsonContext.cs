using System.Text.Json.Serialization;
using X01.App.Alarm.Models;

[JsonSerializable(typeof(Project))]
[JsonSerializable(typeof(AlarmRecord))]
[JsonSerializable(typeof(ProjectsJson))]
[JsonSerializable(typeof(Category))]
[JsonSerializable(typeof(Tag))]
public partial class JsonContext : JsonSerializerContext
{
}