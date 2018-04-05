using System.Runtime.Serialization;

namespace ThisDayInHistory
{
    public class Event
    {
        [DataMember(Name = "year")]
        public string Year { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}