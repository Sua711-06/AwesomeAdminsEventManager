namespace AwesomeAdminsEventManager.Models {
    public class Category {
        public int CategoryId { get; set; }
        public string Name { get; set; } = String.Empty;
        public int EventId { get; set; }

        //foreign key relationship
        public Event? Event { get; set; }
    }
}
