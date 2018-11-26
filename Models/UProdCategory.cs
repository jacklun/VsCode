using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UProdCategory {
        [Key]
        public int id { get; set; }

        public int prodCategoryId { get; set; }
        public ProdCategory prodCategory { get; set; }
        public int userBaseId { get; set; }
        public UserBase userBase { get; set; }
    }
}