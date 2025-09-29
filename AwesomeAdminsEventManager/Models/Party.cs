using System.ComponentModel.DataAnnotations;

namespace AwesomeAdminsPartyManager.Models {
    public class Party {
        [Display(Name = "Party ID")]
        public int PartyId { get; set; }

        [Display(Name = "Party Name")]
        public string Name { get; set; } = String.Empty;

        [Display(Name = "Party Description")]
        public string Description { get; set; } = String.Empty;

        [Display(Name = "Party Date")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Party Location")]
        public string Location { get; set; } = String.Empty;

        [Display(Name = "Party Owner")]
        public string Owner { get; set; } = String.Empty;

        [Display(Name = "Created At")]
        public DateTime Created { get; set; }

        [Display(Name = "Categories")]
        public List<Category>? Categories { get; set; }
    }
}