using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebEditor.Models {
    public class UImage {
        [Key]
        public int id { get; set; }

        public int userBaseId { get; set; }
        public UserBase userBase { get; set; }

        public int imageId { get; set; }
        public Image image { get; set; }
    }
}