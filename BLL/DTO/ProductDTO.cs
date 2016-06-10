using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }

        public string Title { get; set; }
       
        public string Intro { get; set; }

        public string Body { get; set; }

        public bool Hidden { get; set; }
        public DateTime Created { get; set; }
        public List<CommentDTO> Comments { get; set; } = new List<CommentDTO>();
    }
}
