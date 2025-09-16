namespace AwesomeAdminsTicketManager.Models {
    public class EventItem {
        public int EventItemId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public List<Tag>? Tags { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string Location { get; set; } = String.Empty;
        public string Owner { get; set; } = String.Empty;
        public DateTime Created { get; set; }
    }
}