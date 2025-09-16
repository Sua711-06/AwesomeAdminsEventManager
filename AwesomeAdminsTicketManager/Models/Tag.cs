namespace AwesomeAdminsTicketManager.Models {
    public class Tag {
        public int TagId { get; set; }
        public string Name { get; set; } = String.Empty;
        public int EventItemId { get; set; }
        public EventItem? EventItem { get; set; }
    }
}
