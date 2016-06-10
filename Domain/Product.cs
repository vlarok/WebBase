using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Intro { get; set; }
        [MaxLength(2000)]
        public string Body { get; set; }

        public bool Hidden { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}

