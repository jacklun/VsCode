using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UserDetial {
        [Key]
        public int id { get; set; }

        [StringLength (50, MinimumLength = 10, ErrorMessage = "ok")]
        public string openid { get; set; }

        [Required, DisplayName ("用户名"), StringLength (10, MinimumLength = 2, ErrorMessage = "ok")]
        public string name { get; set; }

        [Required, DisplayName ("密码"), StringLength (20, MinimumLength = 3, ErrorMessage = "ok")]
        public string password { get; set; }

        [DisplayName ("昵称"), StringLength (10, MinimumLength = 3, ErrorMessage = "ok")]
        public string nickname { get; set; }

        [DisplayName ("手机"), StringLength (20, MinimumLength = 3, ErrorMessage = "ok")]
        public string phone { get; set; }

        [DisplayName ("头像"), StringLength (50, MinimumLength = 3, ErrorMessage = "ok")]
        public string photo { get; set; }

        [DisplayName ("签名档"), StringLength (200, MinimumLength = 3, ErrorMessage = "ok")]
        public string signatureline { get; set; }

        [ForeignKey ("UserBase")]
        public int userBaseId { get; set; }
        public virtual UserBase userBase { get; set; }
    }
}