using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebEditor.Models {
    public class ArtRefImage {
        [Key]
        public int id { get; set; }

        [StringLength (300, MinimumLength = 3, ErrorMessage = "URL必须大于3字，小于等于300字")]
        public string url { get; set; }

        public int articleId { get; set; }
        public Article article { get; set; }
    }
}