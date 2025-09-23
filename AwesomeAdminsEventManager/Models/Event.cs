using System.ComponentModel.DataAnnotations;

namespace AwesomeAdminsEventManager.Models {
    public class Event {
        [Display(Name = "Event ID")]
        public int EventId { get; set; }

        [Display(Name = "Event Name")]
        public string Name { get; set; } = String.Empty;

        [Display(Name = "Event Description")]
        public string Description { get; set; } = String.Empty;

        [Display(Name = "Event Date")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Event Location")]
        public string Location { get; set; } = String.Empty;

        [Display(Name = "Event Owner")]
        public string Owner { get; set; } = String.Empty;

        [Display(Name = "Created At")]
        public DateTime Created { get; set; }

        [Display(Name = "Categories")]
        public List<Category>? Categories { get; set; }
    }
}