using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class Industry {
        [Key]
        public int id { get; set; }

        [Required, StringLength (50, MinimumLength = 2, ErrorMessage = "ok")]
        public string name { get; set; }
        public int companyId { get; set; }
        public Company company { get; set; }
    }
}