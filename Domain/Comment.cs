using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int ProductId { get; set; }

        [MaxLength(2000)]
        public string CommentText { get; set; }
        public virtual Product Product { get; set; }

    }
}
