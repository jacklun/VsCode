using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UArtCategory {
        [Key]
        public int id { get; set; }
        public int artCategoryId { get; set; }
        public ArtCategory artCategory { get; set; }
        public int userBaseId { get; set; }
        public UserBase userBase { get; set; }
    }
}