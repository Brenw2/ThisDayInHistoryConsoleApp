using System.Runtime.Serialization;

namespace ThisDayInHistory
{
    public class ApiHistoryModel
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "Data")]
        public HistoricalData Data { get; set; }
    }
}