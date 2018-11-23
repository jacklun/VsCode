using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebEditor.Models {
    public class UserFollowProdCategory {
        [Key]
        public int id { get; set; }

        //[ForeignKey ("UserRelationship")]
        //public int UserDetialId { get; set; }
        //public virtual UserDetial userdetial { get; set; }
    }
}