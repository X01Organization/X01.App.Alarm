using System.Text.Json.Serialization;

namespace X01.App.Alarm.Models
{
    public class AlarmRecord
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }

        [JsonIgnore]
        public int ProjectID { get; set; }
    }
}