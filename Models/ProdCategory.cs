using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class ProdCategory {
        [Key]
        public int id { get; set; }

        [StringLength (10, MinimumLength = 2, ErrorMessage = "产品名称必须大于2字，小于等于10字")]
        public string tname { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<UserProdCategory> UserProdCategorys { get; set; }
        public IEnumerable<UserFollowProdCategory> UserFollowProdCategorys { get; set; }
    }
}