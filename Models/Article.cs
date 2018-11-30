using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class Article {
        [Key]
        public int id { get; set; }

        [StringLength (30, MinimumLength = 3, ErrorMessage = "文章名称必须大于3字，小于等于30字")]
        public string name { get; set; }

        [StringLength (10000, MinimumLength = 10, ErrorMessageResourceName = "文章内容必须大于10字，小于等于10000字")]
        public string description { get; set; }
        //文章优先级1-4，默认是新文章，优先级为2，看过的优先级为4，在关注的文章目录为3，在关注的文章目录，且为新文章为1
        public int priority { get; set; }
        public int artCategoryId { get; set; }
        public ArtCategory artCategory { get; set; }

        public int artMainRefImageId { get; set; }
        public ArtRefImage artMainRefImage { get; set; }

        public IEnumerable<ArtRefImage> artRefImages { get; set; }
    }
}