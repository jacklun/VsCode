using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class ArtCategory {
        [Key]
        public int id { get; set; }

        [StringLength (30, MinimumLength = 3, ErrorMessage = "文章名称必须大于3字，小于等于30字")]
        public string name { get; set; }
        public IEnumerable<Article> articles { get; set; }
        //public IEnumerable<UArtCategory> uArtCategorys { get; set; }
        public IEnumerable<UFolwArtCategory> uFolwArtCategorys { get; set; }
    }
}