using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class ProdCategory {
        [Key]
        public int id { get; set; }

        [StringLength (10, MinimumLength = 2, ErrorMessage = "产品名称必须大于2字，小于等于10字")]
        public string name { get; set; }
        public IEnumerable<Product> products { get; set; }
        public IEnumerable<UProdCategory> uProdCategorys { get; set; }
        public IEnumerable<UFolwProdCategory> uFolwProdCategorys { get; set; }

    }
}