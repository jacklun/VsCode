using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebEditor.Models {
    public class UImage {
        [Key]
        public int id { get; set; }

        [StringLength (300, MinimumLength = 3, ErrorMessage = "URL必须大于3字，小于等于300字")]
        public string url { get; set; }
        public IEnumerable<ArtRefImage> artRefImage { get; set; }
    }
}