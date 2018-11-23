using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class ArticleCategory {
        [Key]
        public int id { get; set; }

        [StringLength (30, MinimumLength = 3, ErrorMessage = "文章名称必须大于3字，小于等于30字")]
        public string aname { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public IEnumerable<UserArticleCategory> UserArticleCategorys { get; set; }
    }
}