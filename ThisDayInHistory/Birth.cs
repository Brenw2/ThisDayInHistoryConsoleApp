using System.Runtime.Serialization;

namespace ThisDayInHistory
{
    public class Birth
    {
        [DataMember(Name = "year")]
        public string Year { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}