using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UserRelationship {
        [Key]
        public int id { get; set; }

        [StringLength (50, MinimumLength = 10, ErrorMessage = "ok")]
        public string openid { get; set; }

        [Required, DisplayName ("用户名"), StringLength (10, MinimumLength = 2, ErrorMessage = "ok")]
        public string uname { get; set; }

        [Required, DisplayName ("密码"), StringLength (20, MinimumLength = 3, ErrorMessage = "ok")]
        public string password { get; set; }

        [DisplayName ("手机"), StringLength (20, MinimumLength = 3, ErrorMessage = "ok")]
        public string phone { get; set; }

        [ForeignKey ("UserBase")]
        public int UserBaseId { get; set; }
        public virtual UserBase userBase { get; set; }
        public IEnumerable<UserImage> UserImages { get; set; }

        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<Product> Products { get; set; }
        //[DisplayName ("我的公司")]
        public virtual Company company { get; set; }
        public IEnumerable<UserArtCategory> UserArtCategorys { get; set; }
        public IEnumerable<UserProdCategory> UserProdCategorys { get; set; }
        public IEnumerable<UserFollowArtCategory> UserFollowArtCategorys { get; set; }
        public IEnumerable<UserFollowProdCategory> UserFollowProdCategorys { get; set; }
    }
}