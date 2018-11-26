using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UserBase {
        [Key]
        public int id { get; set; }

        [StringLength (50, MinimumLength = 10, ErrorMessage = "ok")]
        public string openid { get; set; }

        [Required, DisplayName ("用户名"), StringLength (10, MinimumLength = 2, ErrorMessage = "ok")]
        public string name { get; set; }

        [Required, DisplayName ("密码"), StringLength (20, MinimumLength = 3, ErrorMessage = "ok")]
        public string password { get; set; }

        [DisplayName ("手机"), StringLength (20, MinimumLength = 3, ErrorMessage = "ok")]
        public string phone { get; set; }
        public virtual UserDetial userDetial { get; set; }
        public virtual Company company { get; set; }
        public ICollection<UFolwArtCategory> uFolwArtCategorys { get; set; }
        public ICollection<UFolwProdCategory> uFolwProdCategorys { get; set; }
        public IEnumerable<UArtCategory> uArtCategorys { get; set; }
        public IEnumerable<UProdCategory> uProdCategorys { get; set; }
    }
}