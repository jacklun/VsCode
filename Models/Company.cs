using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class Company {
        [Key]
        public int id { get; set; }

        [Required, StringLength (50, MinimumLength = 2, ErrorMessage = "ok")]
        public string name { get; set; }
        //[Required, StringLength (50, ErrorMessage = "ok")]
        //public virtual Industry industry { get; set; }

        [Required, StringLength (50, ErrorMessage = "ok")]
        public string mainBusiness { get; set; }

        [Required, StringLength (200, ErrorMessage = "ok")]
        public string description { get; set; }

        [ForeignKey ("UserBase")]
        public int userBaseId { get; set; }
        public IEnumerable<Industry> industrys { get; set; }
    }
}