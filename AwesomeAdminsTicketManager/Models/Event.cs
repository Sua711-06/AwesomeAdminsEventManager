namespace AwesomeAdminsTicketManager.Models {
    public class Event {
        public int EventId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string Location { get; set; } = String.Empty;
        public string Owner { get; set; } = String.Empty;
        public DateTime Created { get; set; }

        //navigation property
        public List<Category>? Categories { get; set; }
    }
}