using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebEditor.Models {
    public class Product {
        [Key]
        public int id { get; set; }

        [StringLength (30, MinimumLength = 3, ErrorMessage = "产品名称必须大于3字，小于等于30字")]
        public string pname { get; set; }

        [StringLength (200, MinimumLength = 10, ErrorMessage = "产品描述必须大于10字，小于等于200字")]
        public string description { get; set; }

        [DefaultValue (0)]
        public decimal price { get; set; }

        [DefaultValue (0)]
        public decimal discount { get; set; }

        [StringLength (200, MinimumLength = 10, ErrorMessage = "产品描述必须大于10字，小于等于200字")]
        public string image_url { get; set; }
        public int ProdCategoryId { get; set; }
        public ProdCategory prodcategory { get; set; }
    }
}