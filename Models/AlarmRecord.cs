using System.Text.Json.Serialization;

namespace X01.App.Alarm.Models
{
    public class AlarmRecord
    {
        public int ID { get; set; }

        public string Title { get; set; } = "Test alarm";
        public TimeSpan Time { get; set; } = new (3,3,3);
        public DateTime Date { get; set; } = new (2023,3,3);

        public bool IsCompleted { get; set; }

        [JsonIgnore]
        public int ProjectID { get; set; }
    }
}