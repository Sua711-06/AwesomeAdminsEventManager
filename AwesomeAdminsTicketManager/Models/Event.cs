using System.ComponentModel.DataAnnotations;

namespace AwesomeAdminsEventManager.Models {
    public class Event {
        [Display(Name = "Event ID")]
        public int EventId { get; set; }
        [Display(Name = "Event Title")]
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